using AgendaApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaApi.Data.Seeds;

public class AgendaSeed : IEntityTypeConfiguration<Agenda>
{
    public void Configure(EntityTypeBuilder<Agenda> builder)
    {
        builder.HasData(
            new Agenda { Id_usuario = "u-eddy-67015593", Id_evento = 1, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-eddy-67015593", Id_evento = 2, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-eddy-67015593", Id_evento = 3, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-eddy-67015593", Id_evento = 4, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-eddy-67015593", Id_evento = 5, Estado = "Aceptado" },

            // --- Agendas para Lizeth (Eventos 6 al 10) ---
            new Agenda { Id_usuario = "u-lizeth-60171101", Id_evento = 6, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-lizeth-60171101", Id_evento = 7, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-lizeth-60171101", Id_evento = 8, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-lizeth-60171101", Id_evento = 9, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-lizeth-60171101", Id_evento = 10, Estado = "Aceptado" },

            // --- Agendas para Juan (Eventos 11 al 15) ---
            new Agenda { Id_usuario = "u-juan-1001", Id_evento = 11, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-juan-1001", Id_evento = 12, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-juan-1001", Id_evento = 13, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-juan-1001", Id_evento = 14, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-juan-1001", Id_evento = 15, Estado = "Aceptado" },

            // --- Agendas para Maria (Eventos 16 al 20) ---
            new Agenda { Id_usuario = "u-maria-1002", Id_evento = 16, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-maria-1002", Id_evento = 17, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-maria-1002", Id_evento = 18, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-maria-1002", Id_evento = 19, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-maria-1002", Id_evento = 20, Estado = "Aceptado" },

            // --- Agendas para Carlos (Eventos 21 al 25) ---
            new Agenda { Id_usuario = "u-carlos-1003", Id_evento = 21, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-carlos-1003", Id_evento = 22, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-carlos-1003", Id_evento = 23, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-carlos-1003", Id_evento = 24, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-carlos-1003", Id_evento = 25, Estado = "Aceptado" },

            // --- Agendas para los restantes 15 creadores (Eventos 26 al 40) ---
            new Agenda { Id_usuario = "u-ana-1004", Id_evento = 26, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-pedro-1005", Id_evento = 27, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-lucia-1006", Id_evento = 28, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-jorge-1007", Id_evento = 29, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-elena-1008", Id_evento = 30, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-luis-1009", Id_evento = 31, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-sofia-1010", Id_evento = 32, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-miguel-1011", Id_evento = 33, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-laura-1012", Id_evento = 34, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-raul-1013", Id_evento = 35, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-marta-1014", Id_evento = 36, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-david-1015", Id_evento = 37, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-claudia-1016", Id_evento = 38, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-oscar-1017", Id_evento = 39, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-silvia-1018", Id_evento = 40, Estado = "Aceptado" },

            new Agenda { Id_usuario = "u-lizeth-60171101", Id_evento = 1, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-juan-1001", Id_evento = 1, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-maria-1002", Id_evento = 1, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-carlos-1003", Id_evento = 1, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-ana-1004", Id_evento = 1, Estado = "Pendiente" },
            new Agenda { Id_usuario = "u-pedro-1005", Id_evento = 1, Estado = "Pendiente" },
            new Agenda { Id_usuario = "u-lucia-1006", Id_evento = 1, Estado = "Pendiente" },

            new Agenda { Id_usuario = "u-lizeth-60171101", Id_evento = 2, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-juan-1001", Id_evento = 2, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-maria-1002", Id_evento = 2, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-carlos-1003", Id_evento = 2, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-ana-1004", Id_evento = 2, Estado = "Pendiente" },
            new Agenda { Id_usuario = "u-pedro-1005", Id_evento = 2, Estado = "Pendiente" },
            new Agenda { Id_usuario = "u-lucia-1006", Id_evento = 2, Estado = "Pendiente" },

            new Agenda { Id_usuario = "u-lizeth-60171101", Id_evento = 3, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-juan-1001", Id_evento = 3, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-maria-1002", Id_evento = 3, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-carlos-1003", Id_evento = 3, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-ana-1004", Id_evento = 3, Estado = "Pendiente" },
            new Agenda { Id_usuario = "u-pedro-1005", Id_evento = 3, Estado = "Pendiente" },
            new Agenda { Id_usuario = "u-lucia-1006", Id_evento = 3, Estado = "Pendiente" },

            new Agenda { Id_usuario = "u-lizeth-60171101", Id_evento = 4, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-juan-1001", Id_evento = 4, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-maria-1002", Id_evento = 4, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-carlos-1003", Id_evento = 4, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-ana-1004", Id_evento = 4, Estado = "Pendiente" },
            new Agenda { Id_usuario = "u-pedro-1005", Id_evento = 4, Estado = "Pendiente" },
            new Agenda { Id_usuario = "u-lucia-1006", Id_evento = 4, Estado = "Pendiente" },

            new Agenda { Id_usuario = "u-lizeth-60171101", Id_evento = 5, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-juan-1001", Id_evento = 5, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-maria-1002", Id_evento = 5, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-carlos-1003", Id_evento = 5, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-ana-1004", Id_evento = 5, Estado = "Pendiente" },
            new Agenda { Id_usuario = "u-pedro-1005", Id_evento = 5, Estado = "Pendiente" },
            new Agenda { Id_usuario = "u-lucia-1006", Id_evento = 5, Estado = "Pendiente" },

            new Agenda { Id_usuario = "u-eddy-67015593", Id_evento = 6, Estado = "Pendiente" },
            new Agenda { Id_usuario = "u-juan-1001", Id_evento = 6, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-maria-1002", Id_evento = 6, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-carlos-1003", Id_evento = 6, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-ana-1004", Id_evento = 6, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-pedro-1005", Id_evento = 6, Estado = "Pendiente" },
            new Agenda { Id_usuario = "u-lucia-1006", Id_evento = 6, Estado = "Pendiente" },

            new Agenda { Id_usuario = "u-eddy-67015593", Id_evento = 7, Estado = "Pendiente" },
            new Agenda { Id_usuario = "u-juan-1001", Id_evento = 7, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-maria-1002", Id_evento = 7, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-carlos-1003", Id_evento = 7, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-ana-1004", Id_evento = 7, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-pedro-1005", Id_evento = 7, Estado = "Pendiente" },
            new Agenda { Id_usuario = "u-lucia-1006", Id_evento = 7, Estado = "Pendiente" },

            new Agenda { Id_usuario = "u-eddy-67015593", Id_evento = 8, Estado = "Pendiente" },
            new Agenda { Id_usuario = "u-juan-1001", Id_evento = 8, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-maria-1002", Id_evento = 8, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-carlos-1003", Id_evento = 8, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-ana-1004", Id_evento = 8, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-pedro-1005", Id_evento = 8, Estado = "Pendiente" },
            new Agenda { Id_usuario = "u-lucia-1006", Id_evento = 8, Estado = "Pendiente" },

            new Agenda { Id_usuario = "u-eddy-67015593", Id_evento = 9, Estado = "Pendiente" },
            new Agenda { Id_usuario = "u-juan-1001", Id_evento = 9, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-maria-1002", Id_evento = 9, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-carlos-1003", Id_evento = 9, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-ana-1004", Id_evento = 9, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-pedro-1005", Id_evento = 9, Estado = "Pendiente" },
            new Agenda { Id_usuario = "u-lucia-1006", Id_evento = 9, Estado = "Pendiente" },

            new Agenda { Id_usuario = "u-eddy-67015593", Id_evento = 10, Estado = "Pendiente" },
            new Agenda { Id_usuario = "u-juan-1001", Id_evento = 10, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-maria-1002", Id_evento = 10, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-carlos-1003", Id_evento = 10, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-ana-1004", Id_evento = 10, Estado = "Aceptado" },
            new Agenda { Id_usuario = "u-pedro-1005", Id_evento = 10, Estado = "Pendiente" },
            new Agenda { Id_usuario = "u-lucia-1006", Id_evento = 10, Estado = "Pendiente" }
        );
    }
}