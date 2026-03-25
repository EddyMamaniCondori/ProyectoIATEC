using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

public class EventoCreateDto : IValidatableObject
{
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string Nombre { get; set; } = null!;

    [Required(ErrorMessage = "La descripción es necesaria para los invitados.")]
    public string Descripcion { get; set; } = null!;

    [Required(ErrorMessage = "Debes indicar cuándo inicia el evento.")]
    public DateTime Fecha_inicio { get; set; } 

    [Required(ErrorMessage = "La fecha de finalización es obligatoria.")]
    public DateTime Fecha_finalizacion { get; set; } 

    [Required(ErrorMessage = "La hora de inicio es requerida.")] 
    public string Hora_inicio { get; set; } = null!;

    [Required(ErrorMessage = "La hora de finalización es requerida.")]
    public string Hora_finalizacion { get; set; } = null!;
 
    [Required(ErrorMessage = "El lugar es obligatorio para el mapa.")]
    public string Lugar { get; set; } = null!;

    [Required(ErrorMessage = "La latitud es necesaria.")]
    public double Latitud { get; set; } 

    [Required(ErrorMessage = "La longitud es necesaria.")]
    public double Longitud { get; set; }

    [Required(ErrorMessage = "Selecciona si el evento es Exclusivo o Compartido.")]
    public required string Tipo { get; set; }

    
    public IFormFile? Imagen_file { get; set; }

    
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var hoy = DateTime.Today;

        
        if (Fecha_inicio.Date < hoy)
        {
            yield return new ValidationResult(
                "La fecha de inicio no puede ser menor a hoy.",
                new[] { nameof(Fecha_inicio) }
            );
        }

        
        if (Fecha_finalizacion.Date < Fecha_inicio.Date)
        {
            yield return new ValidationResult(
                "La fecha de finalización no puede ser anterior a la fecha de inicio.",
                new[] { nameof(Fecha_finalizacion) }
            );
        }
    }
}