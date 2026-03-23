using AgendaApi.Data;
using AgendaApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Text.Json;

namespace AgendaApi.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize] // Solo usuarios autenticados pueden ver sus eventos
public class EventosController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public EventosController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet("mis-eventos")]
    public async Task<IActionResult> GetMisEventos()
    {
        // 1. Obtener el ID del usuario logueado desde el Token
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (userId == null) return Unauthorized();

        // 2. Consultar eventos propios Y eventos donde fue invitado (Agenda)
        var eventos = await _context.Eventos
            .Where(e => e.Id_usuario == userId || _context.Agendas.Any(a => a.Id_evento == e.Id_evento && a.Id_usuario == userId))
            .Select(e => new {
                id = e.Id_evento,
                title = e.Nombre,
                start = e.Fecha_inicio.ToString("yyyy-MM-dd") + "T" + e.Hora_inicio.ToString(@"hh\:mm\:ss"),
                end = e.Fecha_finalizacion.ToString("yyyy-MM-dd") + "T" + e.Hora_finalizacion.ToString(@"hh\:mm\:ss"),
                description = e.Descripcion,
                lugar = e.Lugar,
                tipo = e.Tipo,
                // Color diferenciador: Si es suyo es azul, si es invitado es verde
                backgroundColor = e.Id_usuario == userId ? "#3788d8" : "#28a745",
                borderColor = e.Id_usuario == userId ? "#3788d8" : "#28a745"
            })
            .ToListAsync();
        var jsonString = JsonSerializer.Serialize(eventos, new JsonSerializerOptions { WriteIndented = true });
        Console.WriteLine("---- DATOS ENVIADOS AL CALENDARIO ----");
        Console.WriteLine(jsonString);

    
        return Ok(eventos);
    }
}