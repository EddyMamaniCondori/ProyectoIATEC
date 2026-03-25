using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaApi.Models;

public class Agenda
{
    
    [Required]
    public string Id_usuario { get; set; } = string.Empty;

    [ForeignKey("Id_usuario")]
    public virtual Usuario? Usuario { get; set; }
    
    [Required]
    public int Id_evento { get; set; }
    [ForeignKey("Id_evento")]
    public virtual Evento? Evento { get; set; }
    
    [Required]
    public string Estado { get; set; } = "Pendiente"; // "Aceptado" o "Pendiente"
    public DateTime FechaAsignacion { get; set; } = DateTime.UtcNow;
}