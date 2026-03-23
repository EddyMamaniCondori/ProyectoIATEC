using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaApi.Models;

public class Evento
{
    [Key]
    public int Id_evento { get; set; }

    [Required]
    [StringLength(150)]
    public string Nombre { get; set; } = string.Empty;

    public string? Descripcion { get; set; }

    [Required]
    public DateTime Fecha_inicio { get; set; }

    [Required]
    public DateTime Fecha_finalizacion { get; set; }

    public string? Lugar { get; set; }

    [Required]
    public string Tipo { get; set; } // "Exclusivo" o "Compartido"


    public double? Latitud { get; set; }
    public double? Longitud { get; set; }

    public string? Imagen { get; set; }

    [Required]
    public TimeSpan Hora_inicio { get; set; }

    [Required]
    public TimeSpan Hora_finalizacion { get; set; }

    // --- RELACIÓN CON USUARIO (Creador) ---
    
    [Required]
    public string Id_usuario { get; set; } // FK: Tipo string para coincidir con AspNetUsers

    [ForeignKey("Id_usuario")]
    public virtual Usuario? Creador { get; set; } // Propiedad de navegación
}