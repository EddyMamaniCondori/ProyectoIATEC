using AgendaApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaApi.Data.Seeds;

public class EventoSeed : IEntityTypeConfiguration<Evento>
{
    public void Configure(EntityTypeBuilder<Evento> builder)
    {
        builder.HasData(
            new Evento { 
                Id_evento = 1, Id_usuario = "u-eddy-67015593", Nombre = "Reunión de Proyecto IATEC", 
                Tipo = "Compartido", 
                Fecha_inicio = DateTime.SpecifyKind(new DateTime(2026, 3, 25), DateTimeKind.Utc), // Fecha estática
                Hora_inicio = new TimeSpan(9, 0, 0), 
                Hora_finalizacion = new TimeSpan(11, 0, 0), 
                Fecha_finalizacion = DateTime.SpecifyKind(new DateTime(2026, 3, 25), DateTimeKind.Utc), 
                Lugar = "Oficina Central" 
            },
            new Evento { 
                Id_evento = 2, Id_usuario = "u-eddy-67015593", Nombre = "Partido de Futbol", 
                Tipo = "Exclusivo", 
                Fecha_inicio = DateTime.SpecifyKind(new DateTime(2026, 3, 26), DateTimeKind.Utc), 
                Hora_inicio = new TimeSpan(19, 0, 0), 
                Hora_finalizacion = new TimeSpan(21, 0, 0), 
                Fecha_finalizacion = DateTime.SpecifyKind(new DateTime(2026, 3, 26), DateTimeKind.Utc), 
                Lugar = "Cancha 5" 
            },
            new Evento { 
                Id_evento = 3, Id_usuario = "u-lizeth-60171101", Nombre = "Presentación de Tesis", 
                Tipo = "Compartido", 
                Fecha_inicio = DateTime.SpecifyKind(new DateTime(2026, 3, 25), DateTimeKind.Utc),
                Hora_inicio = new TimeSpan(14, 0, 0), 
                Hora_finalizacion = new TimeSpan(16, 0, 0), 
                Fecha_finalizacion = DateTime.SpecifyKind(new DateTime(2026, 3, 25), DateTimeKind.Utc), 
                Lugar = "Auditorio" 
            },
            new Evento { 
                Id_evento = 4, Id_usuario = "u-lizeth-60171101", Nombre = "Cita Dental", 
                Tipo = "Exclusivo", 
                Fecha_inicio = DateTime.SpecifyKind(new DateTime(2026, 3, 27), DateTimeKind.Utc),
                Hora_inicio = new TimeSpan(10, 0, 0), 
                Hora_finalizacion = new TimeSpan(11, 0, 0), 
                Fecha_finalizacion = DateTime.SpecifyKind(new DateTime(2026, 3, 27), DateTimeKind.Utc), 
                Lugar = "Clínica Dental" 
            }
        );
    }
}