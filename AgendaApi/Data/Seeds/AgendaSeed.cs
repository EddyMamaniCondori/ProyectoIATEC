using AgendaApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaApi.Data.Seeds;

public class AgendaSeed : IEntityTypeConfiguration<Agenda>
{
    public void Configure(EntityTypeBuilder<Agenda> builder)
    {
        builder.HasData(
            // Eddy invita a Lizeth a sus eventos
            new Agenda { Id_usuario = "u-lizeth-60171101", Id_evento = 1, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-lizeth-60171101", Id_evento = 2, Estado = "Pendiente" },

            // Lizeth invita a Eddy a sus eventos
            new Agenda { Id_usuario = "u-eddy-67015593", Id_evento = 3, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-eddy-67015593", Id_evento = 4, Estado = "Pendiente" }
        );
    }
}