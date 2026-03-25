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
    public class DashboardController : ControllerBase
    {
        private readonly IHubContext<NotificacionHub> _hubContext;
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context, IHubContext<NotificacionHub> hubContext)
        {
            _context = context;
            _hubContext = hubContext;
        }
        [HttpGet("resumen")]
        public async Task<IActionResult> GetResumen()
        {
            try
            {
                var ahora = DateTime.Now;
                // El '!' al final indica al compilador que confiamos en que el ID no es nulo
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;

                // 🔍 LÓGICA DE AGENDA: Include del modelo Evento + Filtro de Usuario y Estado
                var agendasUsuario = await _context.Agendas
                    .Include(a => a.Evento) 
                    .Where(a => a.Id_usuario == userId && a.Estado == "Aceptado")
                    .ToListAsync();

                // Extraemos la lista de objetos Evento de la tabla puente Agenda
                var eventos = agendasUsuario
                    .Select(a => a.Evento!)
                    .ToList();

                // 📊 CLASIFICACIÓN USANDO TUS PROPIEDADES EXACTAS
                var resumen = new
                {
                    // EVENTOS SUCEDIENDO AHORA
                    EnCurso = eventos.Where(e => {
                        // Unimos la Fecha (DateTime) con la Hora (TimeSpan)
                        var inicio = e.Fecha_inicio.Date.Add(e.Hora_inicio);
                        var fin = e.Fecha_finalizacion.Date.Add(e.Hora_finalizacion);
                        return ahora >= inicio && ahora <= fin;
                    }).OrderBy(e => e.Fecha_finalizacion).ToList(),

                    // EVENTOS QUE VIENEN DESPUÉS
                    Proximos = eventos.Where(e => {
                        var inicio = e.Fecha_inicio.Date.Add(e.Hora_inicio);
                        return inicio > ahora;
                    }).OrderBy(e => e.Fecha_inicio).Take(5).ToList()
                };

                return Ok(resumen);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Error al procesar el dashboard", detalles = ex.Message });
            }
        }

        [HttpGet("mis-eventos")] // Para Google Calendar
        public async Task<IActionResult> GetMisEventos()
        {
            try
            {
                var ahora = DateTime.Now;
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;

                var agendasUsuario = await _context.Agendas
                    .Include(a => a.Evento) 
                    .Where(a => a.Id_usuario == userId && a.Estado == "Aceptado")
                    .ToListAsync();

                // Mapeamos al formato plano que requiere FullCalendar
                var eventosCalendario = agendasUsuario.Select(a => new {
                    id = a.Evento!.Id_evento,
                    title = a.Evento.Nombre,
                    // Formato ISO para el calendario
                    start = a.Evento.Fecha_inicio.Date.Add(a.Evento.Hora_inicio).ToString("yyyy-MM-ddTHH:mm:ss"),
                    end = a.Evento.Fecha_finalizacion.Date.Add(a.Evento.Hora_finalizacion).ToString("yyyy-MM-ddTHH:mm:ss"),
                    
                    // Datos extra para el modal
                    descripcion = a.Evento.Descripcion,
                    lugar = a.Evento.Lugar,
                    tipo = a.Evento.Tipo,
                    latitud = a.Evento.Latitud,
                    longitud = a.Evento.Longitud,
                    imagen = a.Evento.Imagen,
                    fecha_inicio = a.Evento.Fecha_inicio.ToString("yyyy-MM-dd"),
                    hora_inicio = a.Evento.Hora_inicio.ToString(@"hh\:mm"),
                    fecha_finalizacion = a.Evento.Fecha_finalizacion.ToString("yyyy-MM-dd"),
                    hora_finalizacion = a.Evento.Hora_finalizacion.ToString(@"hh\:mm"),

                    // Colores
                    backgroundColor = a.Evento.Tipo == "Exclusivo" ? "#28a745" : "#3788d8",
                    borderColor = a.Evento.Tipo == "Exclusivo" ? "#28a745" : "#3788d8"
                }).ToList();

                return Ok(eventosCalendario); // Devolvemos la lista plana []
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Error al obtener eventos para el calendario", detalle = ex.Message });
            }
        }

    }
}