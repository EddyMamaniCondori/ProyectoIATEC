using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AgendaApi.Models;

public class Evento
{
    [Key]
    public int Id_evento { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(150)]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "La descripción es obligatoria")]
    public string Descripcion { get; set; } = string.Empty; 

    [Required]
    public DateTime Fecha_inicio { get; set; }

    [Required]
    public DateTime Fecha_finalizacion { get; set; }

    [Required(ErrorMessage = "El lugar es obligatorio")]
    public string Lugar { get; set; } = string.Empty; 

    [Required]
    public string Tipo { get; set; } = string.Empty; // "Exclusivo" o "Compartido"

    [Required]
    public double Latitud { get; set; } 

    [Required]
    public double Longitud { get; set; } 

    public string? Imagen { get; set; }

    [Required]
    public TimeSpan Hora_inicio { get; set; }

    [Required]
    public TimeSpan Hora_finalizacion { get; set; }

    // --- RELACIÓN CON USUARIO (Creador) ---
    
    [Required]
    public string Id_usuario { get; set; } = string.Empty; 
    [JsonIgnore]
    [ForeignKey("Id_usuario")]
    public virtual Usuario? Creador { get; set; } 
}