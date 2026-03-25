using AgendaApi.Data;
using AgendaApi.Models;
using AgendaApi.Hubs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.SignalR;

namespace AgendaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MisEventosController : ControllerBase
    {
        private readonly IHubContext<NotificacionHub> _hubContext;
        private readonly ApplicationDbContext _context;

        public MisEventosController(ApplicationDbContext context, IHubContext<NotificacionHub> hubContext)
        {
            _context = context;
            _hubContext = hubContext;
        }


        [HttpGet("mis-eventos")]
        public async Task<IActionResult> GetMisEventos(
            [FromQuery] DateTime? start = null, 
            [FromQuery] DateTime? end = null, 
            [FromQuery] TimeSpan? startTime = null, 
            [FromQuery] TimeSpan? endTime = null,
            [FromQuery] string origen = "creados") 
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId)) return Unauthorized();

            var query = _context.Agendas
                .Include(a => a.Evento)
                .Where(a => a.Id_usuario == userId)
                .AsQueryable();

            //  Filtro de Origen 
            if (origen == "creados") {
                query = query.Where(a => a.Evento.Id_usuario == userId);
            } 
            else if (origen == "invitaciones") {
                query = query.Where(a => a.Evento.Id_usuario != userId);
            }

            if (start.HasValue)
            {
                var startUtc = DateTime.SpecifyKind(start.Value.Date, DateTimeKind.Utc);
                query = query.Where(a => a.Evento.Fecha_inicio >= startUtc);
            }

            if (end.HasValue)
            {
                var limiteSiguienteDia = DateTime.SpecifyKind(end.Value.Date.AddDays(1), DateTimeKind.Utc);
                query = query.Where(a => a.Evento.Fecha_inicio < limiteSiguienteDia);
            }

            
            if (startTime.HasValue || endTime.HasValue)
            {
                var filtroInicio = startTime ?? new TimeSpan(0, 0, 0);
                var filtroFin = endTime ?? new TimeSpan(23, 59, 59);

                query = query.Where(a => 
                    a.Evento.Hora_inicio < filtroFin && 
                    a.Evento.Hora_finalizacion > filtroInicio
                );
            }

            
            var listaBase = await query
                .OrderByDescending(a => a.FechaAsignacion)
                .ToListAsync();

            // Cálculo de Estado en tiempo real y Proyección Final
            var ahora = DateTime.UtcNow;

            var data = listaBase.Select(a => {
                // Combinamos fecha y hora para el estado
                var inicioFull = a.Evento!.Fecha_inicio.Date.Add(a.Evento.Hora_inicio);
                var finFull = a.Evento.Fecha_finalizacion.Date.Add(a.Evento.Hora_finalizacion);
                var inicioUtc = DateTime.SpecifyKind(inicioFull, DateTimeKind.Utc);
                var finUtc = DateTime.SpecifyKind(finFull, DateTimeKind.Utc);

                string estadoTxt = "Próximamente";
                if (ahora > finUtc) estadoTxt = "Concluido";
                else if (ahora >= inicioUtc && ahora <= finUtc) estadoTxt = "En curso";

                return new {
                    id_evento = a.Id_evento,
                    eventoNombre = a.Evento.Nombre,
                    tipo = a.Evento.Tipo,
                    fecha = a.Evento.Fecha_inicio.ToString("dd/MM/yyyy"),
                    horaInicio = a.Evento.Hora_inicio.ToString(@"hh\:mm"),
                    horaFin = a.Evento.Hora_finalizacion.ToString(@"hh\:mm"),
                    lugar = a.Evento.Lugar,
                    invitacion = a.Estado, // Estado de la agenda (Aceptado/Pendiente)
                    estadoEvento = estadoTxt, // Estado del tiempo (En curso, etc)
                    esMio = a.Evento.Id_usuario == userId, // Para saber si yo lo creé
                    quienInvita = _context.Users
                                    .Where(u => u.Id == a.Evento.Id_usuario)
                                    .Select(u => u.Nombre + " " + u.Ape_paterno)
                                    .FirstOrDefault() ?? "Sistema"
                };
            });

            return Ok(new { data });
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId)) return Unauthorized();

            var evento = await _context.Eventos
                .FirstOrDefaultAsync(e => e.Id_evento == id && e.Id_usuario == userId);

            if (evento == null) 
                return NotFound(new { message = "Evento no encontrado o no tienes permiso para eliminarlo." });

            var cantidadAceptados = await _context.Agendas
                .CountAsync(a => a.Id_evento == id && a.Estado == "Aceptado");
            if (cantidadAceptados > 1) 
            {
                return BadRequest(new { 
                    message = "No se puede eliminar el evento.", 
                    detalle = $"Actualmente hay {cantidadAceptados} participantes que ya aceptaron. Debes pedirles que cancelen o notificarlos manualmente antes de borrar." 
                });
            }
            try 
            {
                _context.Eventos.Remove(evento);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Evento eliminado correctamente." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error al intentar eliminar el evento.", detalle = ex.Message });
            }
        }

        [HttpPost("crear")]
        public async Task<IActionResult> Crear([FromForm] EventoCreateDto dto)
        {
            
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId)) return Unauthorized("No se encontró el usuario en el token.");

            if (string.Equals(dto.Tipo, "Exclusivo", StringComparison.OrdinalIgnoreCase))
            {
                var inicioNuevo = DateTime.SpecifyKind(
                    dto.Fecha_inicio.Date.Add(TimeSpan.Parse(dto.Hora_inicio)), 
                    DateTimeKind.Utc
                );
                var finNuevo = DateTime.SpecifyKind(
                    dto.Fecha_finalizacion.Date.Add(TimeSpan.Parse(dto.Hora_finalizacion)), 
                    DateTimeKind.Utc
                );
                var eventoConflicto = await VerificarConflictoExclusivo(userId, inicioNuevo, finNuevo);
                if (eventoConflicto != null)
                {
                    return BadRequest(new { 
                        message = $"No puedes crear este evento. Tienes un evento exclusivo ('{eventoConflicto.Nombre}') programado en este mismo horario.",
                        conflicto = eventoConflicto.Nombre
                    });
                }
            }
            try {
                
                string? nombreImagen = null;
                if (dto.Imagen_file != null && dto.Imagen_file.Length > 0) {
                    
                    nombreImagen = Guid.NewGuid().ToString() + Path.GetExtension(dto.Imagen_file.FileName);
                    var rutaCarpeta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");
                    
                    if (!Directory.Exists(rutaCarpeta)) Directory.CreateDirectory(rutaCarpeta);

                    var rutaCompleta = Path.Combine(rutaCarpeta, nombreImagen);
                    using (var stream = new FileStream(rutaCompleta, FileMode.Create)) {
                        await dto.Imagen_file.CopyToAsync(stream);
                    }
                }

                
                var nuevoEvento = new Evento {
                    Nombre = dto.Nombre,
                    Descripcion = dto.Descripcion,
                    Lugar = dto.Lugar,
                    Tipo = dto.Tipo,
                    Latitud = dto.Latitud,
                    Longitud = dto.Longitud,
                    Imagen = nombreImagen,
                    Id_usuario = userId, // FK del creador
                    
                    // Convertimos las fechas y horas
                    Fecha_inicio = dto.Fecha_inicio.ToUniversalTime(),
                    Fecha_finalizacion = dto.Fecha_finalizacion.ToUniversalTime(),
                    Hora_inicio = TimeSpan.Parse(dto.Hora_inicio),
                    Hora_finalizacion = TimeSpan.Parse(dto.Hora_finalizacion)
                };

                _context.Eventos.Add(nuevoEvento);
                await _context.SaveChangesAsync();

                var autoAgenda = new Agenda {
                    Id_usuario = userId,
                    Evento = nuevoEvento, // EF usará el ID generado automáticamente
                    Estado = "Aceptado",
                    FechaAsignacion = DateTime.UtcNow
                };
                _context.Agendas.Add(autoAgenda);
                await _context.SaveChangesAsync();

                return Ok(new { message = "¡Evento creado con éxito!", id = nuevoEvento.Id_evento });
            }
            catch (Exception ex) {
                return BadRequest(new { message = "Error interno: " + ex.Message });
            }
        }

        private async Task<Evento?> VerificarConflictoExclusivo(string userId, DateTime inicioNuevo, DateTime finNuevo, int? idEventoOmitir = null)
        {
            
            var agendasUsuario = await _context.Agendas
                .Include(a => a.Evento)
                .Where(a => a.Id_usuario == userId && a.Estado == "Aceptado")
                
                .Where(a => idEventoOmitir == null || a.Id_evento != idEventoOmitir)
                .ToListAsync(); 

            
            var conflicto = agendasUsuario
                .Where(a => a.Evento != null && a.Evento.Tipo == "Exclusivo")
                .Select(a => a.Evento!)
                .FirstOrDefault(e => 
                {
                    
                    var inicioExistente = e.Fecha_inicio.Date.Add(e.Hora_inicio);
                    var finExistente = e.Fecha_finalizacion.Date.Add(e.Hora_finalizacion);

                    
                    var inicioExistenteUtc = DateTime.SpecifyKind(inicioExistente, DateTimeKind.Utc);
                    var finExistenteUtc = DateTime.SpecifyKind(finExistente, DateTimeKind.Utc);

                    
                    return inicioNuevo < finExistenteUtc && finNuevo > inicioExistenteUtc;
                });

            return conflicto;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Editar(int id, [FromForm] EventoCreateDto dto)
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId)) return Unauthorized();

            
            var eventoExistente = await _context.Eventos.FirstOrDefaultAsync(e => e.Id_evento == id && e.Id_usuario == userId);
            if (eventoExistente == null) return NotFound("El evento no existe o no tienes permiso.");

            
            if (string.Equals(dto.Tipo, "Exclusivo", StringComparison.OrdinalIgnoreCase))
            {
                var inicioNuevo = DateTime.SpecifyKind(dto.Fecha_inicio.Date.Add(TimeSpan.Parse(dto.Hora_inicio)), DateTimeKind.Utc);
                var finNuevo = DateTime.SpecifyKind(dto.Fecha_finalizacion.Date.Add(TimeSpan.Parse(dto.Hora_finalizacion)), DateTimeKind.Utc);

                var conflicto = await VerificarConflictoExclusivo(userId, inicioNuevo, finNuevo, id);
                if (conflicto != null)
                {
                    return BadRequest(new { message = $"Conflicto con el evento exclusivo: '{conflicto.Nombre}'" });
                }
            }

            try 
            {
                
                if (dto.Imagen_file != null && dto.Imagen_file.Length > 0) 
                {
                    
                    if (!string.IsNullOrEmpty(eventoExistente.Imagen)) {
                        var rutaVieja = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", eventoExistente.Imagen);
                        if (System.IO.File.Exists(rutaVieja)) System.IO.File.Delete(rutaVieja);
                    }

                    var nombreImagen = Guid.NewGuid().ToString() + Path.GetExtension(dto.Imagen_file.FileName);
                    var rutaCarpeta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");
                    var rutaCompleta = Path.Combine(rutaCarpeta, nombreImagen);

                    using (var stream = new FileStream(rutaCompleta, FileMode.Create)) {
                        await dto.Imagen_file.CopyToAsync(stream);
                    }
                    eventoExistente.Imagen = nombreImagen;
                }

                
                eventoExistente.Nombre = dto.Nombre;
                eventoExistente.Descripcion = dto.Descripcion;
                eventoExistente.Lugar = dto.Lugar;
                eventoExistente.Tipo = dto.Tipo;
                eventoExistente.Latitud = dto.Latitud;
                eventoExistente.Longitud = dto.Longitud;
                eventoExistente.Fecha_inicio = dto.Fecha_inicio.ToUniversalTime();
                eventoExistente.Fecha_finalizacion = dto.Fecha_finalizacion.ToUniversalTime();
                eventoExistente.Hora_inicio = TimeSpan.Parse(dto.Hora_inicio);
                eventoExistente.Hora_finalizacion = TimeSpan.Parse(dto.Hora_finalizacion);

                await _context.SaveChangesAsync();
                return Ok(new { message = "¡Evento actualizado con éxito!" });
            }
            catch (Exception ex) {
                return BadRequest(new { message = "Error al actualizar: " + ex.Message });
            }
        }

    }
}