using AgendaApi.Data;
using AgendaApi.Models;
using AgendaApi.Hubs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Text.Json;
using Microsoft.AspNetCore.SignalR;
namespace AgendaApi.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize] // Solo usuarios autenticados pueden ver sus eventos
public class EventosController : ControllerBase
{
    private readonly IHubContext<NotificacionHub> _hubContext;
    private readonly ApplicationDbContext _context;

    public EventosController(ApplicationDbContext context, IHubContext<NotificacionHub> hubContext)
    {
        _context = context;
        _hubContext = hubContext;
    }

    [HttpGet("mis-eventos")]
    public async Task<IActionResult> GetMisEventos()
    {
        var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId)) return Unauthorized();

        var eventos = await _context.Agendas
        .Include(a => a.Evento) // Traemos la información detallada del evento vinculado
        .Where(a => a.Id_usuario == userId && a.Estado == "Aceptado") // Solo lo que aceptó
        .Select(a => new {
            // Usamos 'a.Evento' para acceder a los datos de la otra tabla
            id = a.Evento!.Id_evento,
            title = a.Evento.Nombre,
            
            // Formato para FullCalendar (ISO 8601)
            start = a.Evento.Fecha_inicio.ToString("yyyy-MM-dd") + "T" + a.Evento.Hora_inicio.ToString(@"hh\:mm\:ss"),
            end = a.Evento.Fecha_finalizacion.ToString("yyyy-MM-dd") + "T" + a.Evento.Hora_finalizacion.ToString(@"hh\:mm\:ss"),
            
            // --- DATOS PARA EL MODAL DE DETALLES ---
            nombre = a.Evento.Nombre,
            descripcion = a.Evento.Descripcion,
            lugar = a.Evento.Lugar,
            tipo = a.Evento.Tipo,
            latitud = a.Evento.Latitud,
            longitud = a.Evento.Longitud,
            imagen = a.Evento.Imagen,
            
            // Formatos limpios para los inputs del modal
            hora_inicio = a.Evento.Hora_inicio.ToString(@"hh\:mm"),
            hora_finalizacion = a.Evento.Hora_finalizacion.ToString(@"hh\:mm"),
            fecha_inicio = a.Evento.Fecha_inicio.ToString("yyyy-MM-dd"),
            fecha_finalizacion = a.Evento.Fecha_finalizacion.ToString("yyyy-MM-dd"),
            
            // Colores según el tipo de evento
            backgroundColor = a.Evento.Tipo == "Exclusivo" ? "#28a745" : "#3788d8",
            borderColor = a.Evento.Tipo == "Exclusivo" ? "#28a745" : "#3788d8"
        })
        .ToListAsync();
            //var jsonString = JsonSerializer.Serialize(eventos, new JsonSerializerOptions { WriteIndented = true });
            //Console.WriteLine("---- DATOS ENVIADOS AL CALENDARIO ----");
            //Console.WriteLine(jsonString);

        return Ok(eventos);
    }

    [HttpPost("crear")]
    public async Task<IActionResult> Crear([FromForm] EventoCreateDto dto)
    {
        // 1. Validar que el usuario esté logueado (sacamos el ID del Token)
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
            // 2. Manejo de la Imagen
            string? nombreImagen = null;
            if (dto.Imagen_file != null && dto.Imagen_file.Length > 0) {
                // Generamos un nombre único para que no se sobreescriban
                nombreImagen = Guid.NewGuid().ToString() + Path.GetExtension(dto.Imagen_file.FileName);
                var rutaCarpeta = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");
                
                if (!Directory.Exists(rutaCarpeta)) Directory.CreateDirectory(rutaCarpeta);

                var rutaCompleta = Path.Combine(rutaCarpeta, nombreImagen);
                using (var stream = new FileStream(rutaCompleta, FileMode.Create)) {
                    await dto.Imagen_file.CopyToAsync(stream);
                }
            }

            // 3. Mapeo Manual: DTO -> Entidad de Base de Datos
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

    private async Task<Evento?> VerificarConflictoExclusivo(string userId, DateTime inicioNuevo, DateTime finNuevo)
    {
        // 1. Traemos las agendas aceptadas del usuario
        var agendasUsuario = await _context.Agendas
            .Include(a => a.Evento)
            .Where(a => a.Id_usuario == userId && a.Estado == "Aceptado")
            .ToListAsync(); // Lo traemos a memoria brevemente para asegurar la compatibilidad de suma de fechas

        // 2. Filtramos el conflicto usando la lógica de solapamiento
        var conflicto = agendasUsuario
            .Where(a => a.Evento != null && a.Evento.Tipo == "Exclusivo")
            .Select(a => a.Evento!)
            .FirstOrDefault(e => 
            {
                // Combinamos Fecha + Hora de la base de datos para comparar
                var inicioExistente = e.Fecha_inicio.Date.Add(e.Hora_inicio);
                var finExistente = e.Fecha_finalizacion.Date.Add(e.Hora_finalizacion);

                // IMPORTANTE: Aseguramos que ambos sean tratados como el mismo "Kind" (UTC)
                var inicioExistenteUtc = DateTime.SpecifyKind(inicioExistente, DateTimeKind.Utc);
                var finExistenteUtc = DateTime.SpecifyKind(finExistente, DateTimeKind.Utc);

                // Lógica de Solapamiento
                return inicioNuevo < finExistenteUtc && finNuevo > inicioExistenteUtc;
            });

        return conflicto;
    }

    

    // GET: api/Eventos/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetEvento(int id)
    {
        // 1. Buscamos el ID del usuario logueado en el Token
        var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId)) return Unauthorized();

        // 2. Buscamos el evento que coincida con el ID Y que pertenezca al usuario
        var evento = await _context.Eventos
            .Where(e => e.Id_evento == id)
            .Select(e => new {
                e.Id_evento,
                e.Nombre,
                e.Descripcion,
                e.Lugar,
                e.Tipo,
                e.Latitud,
                e.Longitud,
                e.Imagen,
                // Formateamos para que el JS lo lea fácil
                fecha_inicio = e.Fecha_inicio.ToString("yyyy-MM-dd"),
                fecha_finalizacion = e.Fecha_finalizacion.ToString("yyyy-MM-dd"),
                hora_inicio = e.Hora_inicio.ToString(@"hh\:mm"),
                hora_finalizacion = e.Hora_finalizacion.ToString(@"hh\:mm")
            })
            .FirstOrDefaultAsync();

        if (evento == null)
        {
            return NotFound(new { message = "Evento no encontrado o no tienes permiso." });
        }

        return Ok(evento);
    }

    [HttpGet("{id}/participantes")]
    public async Task<IActionResult> GetParticipantes(int id)
    {
        // Usamos _context.Users que es donde Identity guarda la información de los usuarios
        var participantes = await (from a in _context.Agendas
                               join u in _context.Users on a.Id_usuario equals u.Id
                               where a.Id_evento == id && (a.Estado == "Aceptado" || a.Estado == "Pendiente")
                               select new {
                                   nombre = u.Nombre,
                                   ape_paterno = u.Ape_paterno,
                                   ape_materno = u.Ape_materno,
                                   estado = a.Estado // <--- Agregamos esto para saber qué badge poner
                               }).ToListAsync();

        return Ok(participantes);
    }

    // 1. Obtener usuarios que NO están en el evento, NO son el creador y NO soy yo
    [HttpGet("{id}/usuarios-disponibles")]
    public async Task<IActionResult> GetUsuariosParaInvitar(int id)
    {
        var userIdActual = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

        // IDs de usuarios que ya están en la agenda para este evento
        var usuariosEnEvento = await _context.Agendas
            .Where(a => a.Id_evento == id)
            .Select(a => a.Id_usuario)
            .ToListAsync();

        var usuariosDisponibles = await _context.Users
            .Where(u => u.Id != userIdActual && !usuariosEnEvento.Contains(u.Id))
            .Select(u => new {
                id = u.Id,
                //nombreCompleto = $"{u.Id} {u.Nombre} {u.Ape_paterno} {u.Ape_materno}"
                nombreCompleto = $"{u.Nombre} {u.Ape_paterno} {u.Ape_materno}"

            })
            .ToListAsync();
    
        return Ok(usuariosDisponibles);
    }

    [HttpPost("{id}/invitar")]
    public async Task<IActionResult> InvitarUsuarios(int id, [FromBody] List<string> usuarioIds)
    {
        // Cambiamos el nombre en los logs para que no choque con 'id'
        if (usuarioIds == null || !usuarioIds.Any()) return BadRequest("No se seleccionaron usuarios.");

        // 1. Buscamos el evento (Cambiamos 'id' por 'e' en la lambda para evitar el error CS0136)
        var evento = await _context.Eventos
            .Select(e => new { e.Id_evento, e.Nombre })
            .FirstOrDefaultAsync(e => e.Id_evento == id);

        if (evento == null) return NotFound("El evento no existe.");

        var nombreQuienInvita = User.Identity?.Name ?? "Un usuario";

        // 2. Guardar en base de datos
        foreach (var uId in usuarioIds)
        {
            _context.Agendas.Add(new Agenda {
                Id_evento = id,
                Id_usuario = uId,
                Estado = "Pendiente",
                FechaAsignacion = DateTime.UtcNow
            });
        }
        
        await _context.SaveChangesAsync();

        // --- 🚀 AHORA SÍ, LOS LOGS Y SIGNALR ---
        // Usamos 'tempId' o simplemente no declaramos variable nueva para no chocar
        Console.WriteLine($"📢 Notificando a {usuarioIds.Count} usuarios por el evento: {evento.Nombre}");

        try 
        {
            await _hubContext.Clients.Users(usuarioIds).SendAsync("RecibirInvitacion", new {
                quienInvita = nombreQuienInvita,
                eventoNombre = evento.Nombre,
                idEvento = id
            });
            Console.WriteLine("✅ SignalR envió los mensajes correctamente.");
        }
        catch (Exception ex) 
        {
            Console.WriteLine($"❌ Error en SignalR: {ex.Message}");
        }

        return Ok(new { message = "Invitaciones procesadas." });
    }

    [HttpGet("notificaciones-pendientes")]
    public async Task<IActionResult> GetNotificacionesPendientes()
    {
        // 1. Obtener ID del usuario logueado
        var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId)) return Unauthorized();

        // 2. Buscar las últimas 5 invitaciones pendientes
        var pendientes = await _context.Agendas
            .Include(a => a.Evento)
            .Where(a => a.Id_usuario == userId && a.Estado == "Pendiente")
            .OrderByDescending(a => a.FechaAsignacion)
            .Take(5) 
            .Select(a => new {
                eventoNombre = a.Evento!.Nombre,
                // Buscamos el nombre del creador del evento
                quienInvita = _context.Users
                                .Where(u => u.Id == a.Evento.Id_usuario)
                                .Select(u => u.Nombre + " " + u.Ape_paterno)
                                .FirstOrDefault() ?? "Un usuario"
            })
            .ToListAsync();

        // 3. Contar el total real de pendientes
        var totalPendientes = await _context.Agendas
            .CountAsync(a => a.Id_usuario == userId && a.Estado == "Pendiente");

        return Ok(new { 
            total = totalPendientes, 
            items = pendientes 
        });
    }


}