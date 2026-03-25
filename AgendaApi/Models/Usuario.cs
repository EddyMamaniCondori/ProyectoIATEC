using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
namespace AgendaApi.Models;


public class Usuario : IdentityUser
{
    // Lo dejamos vacío por ahora, o puedes añadir un campo básico
    [Required]
    public string Nombre { get; set; } = string.Empty;
    [Required]
    public string Ape_paterno { get; set; } = string.Empty;
    [Required]
    public DateTime Fecha_naci { get; set; }

    // Campo Opcional (Nullable)
    public string? Ape_materno { get; set; }

    // Foto con valor por defecto
    [Required]
    public string Foto_perfil { get; set; } = "/images/user-default.png";

    public DateTime FechaRegistro { get; set; } = DateTime.UtcNow;

    public virtual ICollection<Evento> MisEventos { get; set; } = new List<Evento>();
    public virtual ICollection<Agenda> MisSuscripciones { get; set; } = new List<Agenda>();
}