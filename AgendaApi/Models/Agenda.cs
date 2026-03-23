using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaApi.Models;

public class Agenda
{
    // Clave Foránea 1: Usuario
    [Required]
    public string Id_usuario { get; set; } = string.Empty;

    [ForeignKey("Id_usuario")]
    public virtual Usuario? Usuario { get; set; }
    // Clave Foránea 2: Evento
    [Required]
    public int Id_evento { get; set; }
    [ForeignKey("Id_evento")]
    public virtual Evento? Evento { get; set; }
    // Atributo Extra
    [Required]
    public string Estado { get; set; } = "Pendiente"; // "Aceptado" o "Pendiente"
    public DateTime FechaAsignacion { get; set; } = DateTime.UtcNow;
}