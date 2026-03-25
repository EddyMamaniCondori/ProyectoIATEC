using AgendaApi.Data;
using AgendaApi.Models;
using AgendaApi.Hubs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Text.Json;
using Microsoft.AspNetCore.SignalR;

namespace AgendaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class InvitacionesController : ControllerBase
    {
        private readonly IHubContext<NotificacionHub> _hubContext;
        private readonly ApplicationDbContext _context;

        public InvitacionesController(ApplicationDbContext context, IHubContext<NotificacionHub> hubContext)
        {
            _context = context;
            _hubContext = hubContext;
        }        
        [HttpPost("{id}/aceptar")]
        public async Task<IActionResult> Aceptar(int id)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId)) return Unauthorized();

            var agenda = await _context.Agendas
                .Include(a => a.Evento)
                .FirstOrDefaultAsync(a => a.Id_evento == id && a.Id_usuario == userId);

            if (agenda == null || agenda.Evento == null) 
                return NotFound(new { message = "La invitación ya no existe." });


            var inicioNuevo = DateTime.SpecifyKind(agenda.Evento.Fecha_inicio.Date.Add(agenda.Evento.Hora_inicio), DateTimeKind.Utc);
            var finNuevo = DateTime.SpecifyKind(agenda.Evento.Fecha_finalizacion.Date.Add(agenda.Evento.Hora_finalizacion), DateTimeKind.Utc);
            var conflicto = await VerificarConflictoExclusivo(userId, inicioNuevo, finNuevo);

            if (conflicto != null)
            {
                return BadRequest(new { 
                    message = "¡Conflicto de horario!", 
                    detalle = $"Ya tienes el evento exclusivo '{conflicto.Nombre}' en este rango de tiempo." 
                });
            }
            agenda.Estado = "Aceptado";
            await _context.SaveChangesAsync();

            return Ok(new { message = "¡Invitación aceptada correctamente!" });
        }


        [HttpPost("{id}/rechazar")]
        public async Task<IActionResult> Rechazar(int id)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId)) return Unauthorized();

            var agenda = await _context.Agendas
                .FirstOrDefaultAsync(a => a.Id_evento == id && a.Id_usuario == userId);

            if (agenda == null) return NotFound(new { message = "Invitación no encontrada." });

            _context.Agendas.Remove(agenda);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Invitación eliminada de tu bandeja." });
        }


        private async Task<Evento?> VerificarConflictoExclusivo(string userId, DateTime inicioNuevo, DateTime finNuevo)
        {
            var agendasUsuario = await _context.Agendas
                .Include(a => a.Evento)
                .Where(a => a.Id_usuario == userId && a.Estado == "Aceptado")
                .ToListAsync();

            var conflicto = agendasUsuario
                .Where(a => a.Evento != null && a.Evento.Tipo == "Exclusivo")
                .Select(a => a.Evento!)
                .FirstOrDefault(e => 
                {
                    var inicioExistente = DateTime.SpecifyKind(e.Fecha_inicio.Date.Add(e.Hora_inicio), DateTimeKind.Utc);
                    var finExistente = DateTime.SpecifyKind(e.Fecha_finalizacion.Date.Add(e.Hora_finalizacion), DateTimeKind.Utc);

                    return inicioNuevo < finExistente && finNuevo > inicioExistente;
                });

            return conflicto;
        }

        [HttpGet("mis-invitaciones")]
        public async Task<IActionResult> GetInvitaciones(
            [FromQuery] DateTime? start = null, 
            [FromQuery] DateTime? end = null, 
            [FromQuery] TimeSpan? startTime = null, 
            [FromQuery] TimeSpan? endTime = null)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId)) return Unauthorized();

            var query = _context.Agendas
                .Include(a => a.Evento)
                .Where(a => a.Id_usuario == userId && a.Evento.Id_usuario != userId)
                .AsQueryable();
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

            var data = await query
                .OrderByDescending(a => a.FechaAsignacion)
                .Select(a => new {
                    id_evento = a.Id_evento,
                    eventoNombre = a.Evento.Nombre,
                    fecha = a.Evento.Fecha_inicio.ToString("dd/MM/yyyy"),
                    lugar = a.Evento.Lugar,
                    estado = a.Estado,
                    tipo = a.Evento.Tipo, 
                    horaInicio = a.Evento.Hora_inicio.ToString(@"hh\:mm"),
                    horaFin = a.Evento.Hora_finalizacion.ToString(@"hh\:mm"),
                    quienInvita = _context.Users
                                    .Where(u => u.Id == a.Evento.Id_usuario)
                                    .Select(u => u.Nombre + " " + u.Ape_paterno)
                                    .FirstOrDefault() ?? "Sistema"
                })
                .ToListAsync();

            return Ok(new { data });
        }

    }
}