using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgendaApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataPostgresCorrecto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Ape_materno", "Ape_paterno", "ConcurrencyStamp", "Email", "EmailConfirmed", "FechaRegistro", "Fecha_naci", "Foto_perfil", "LockoutEnabled", "LockoutEnd", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "u-eddy-67015593", 0, "Condori", "Mamani", "450d9fef-ec72-4dce-8eab-909e7bfd68f7", "eddy@test.com", true, new DateTime(2026, 3, 23, 0, 32, 40, 338, DateTimeKind.Utc).AddTicks(3289), new DateTime(1995, 5, 20, 0, 0, 0, 0, DateTimeKind.Utc), "/images/user-default.png", false, null, "Eddy", "EDDY@TEST.COM", "EDDY@TEST.COM", "AQAAAAIAAYagAAAAEGGv/3MgAV5hR8t0w6pC4wjoJJLCp0sKFhDLpPvh8gMi0F3AnWAE3RQMgJvYU/vMEg==", "67015593", false, "67811d61-3b3a-4313-bf3a-1f1191c14217", false, "eddy@test.com" },
                    { "u-lizeth-60171101", 0, "Fernandez", "Calle", "03854ea1-f3c3-45ae-957f-da8ec5093c2b", "lizeth@test.com", true, new DateTime(2026, 3, 23, 0, 32, 40, 377, DateTimeKind.Utc).AddTicks(4740), new DateTime(1998, 8, 15, 0, 0, 0, 0, DateTimeKind.Utc), "/images/user-default.png", false, null, "Lizeth Aidee", "LIZETH@TEST.COM", "LIZETH@TEST.COM", "AQAAAAIAAYagAAAAEHuqdkg/Uxl0a7b9Rh0y8Dq0OWxA/31bJuSHeSZyd/PEy+qznZNCn70ttNasmQBgLA==", "60171101", false, "4f72a217-fc99-434c-9a18-4c6242f1f811", false, "lizeth@test.com" }
                });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id_evento", "Descripcion", "Fecha_finalizacion", "Fecha_inicio", "Hora_finalizacion", "Hora_inicio", "Id_usuario", "Imagen", "Latitud", "Longitud", "Lugar", "Nombre", "Tipo" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2026, 3, 25, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 3, 25, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 11, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), "u-eddy-67015593", null, null, null, "Oficina Central", "Reunión de Proyecto IATEC", "Compartido" },
                    { 2, null, new DateTime(2026, 3, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 3, 26, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 21, 0, 0, 0), new TimeSpan(0, 19, 0, 0, 0), "u-eddy-67015593", null, null, null, "Cancha 5", "Partido de Futbol", "Exclusivo" },
                    { 3, null, new DateTime(2026, 3, 25, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 3, 25, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 16, 0, 0, 0), new TimeSpan(0, 14, 0, 0, 0), "u-lizeth-60171101", null, null, null, "Auditorio", "Presentación de Tesis", "Compartido" },
                    { 4, null, new DateTime(2026, 3, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 3, 27, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 11, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0), "u-lizeth-60171101", null, null, null, "Clínica Dental", "Cita Dental", "Exclusivo" }
                });

            migrationBuilder.InsertData(
                table: "Agendas",
                columns: new[] { "Id_evento", "Id_usuario", "Estado", "FechaAsignacion" },
                values: new object[,]
                {
                    { 3, "u-eddy-67015593", "Aceptado", new DateTime(2026, 3, 23, 0, 32, 40, 336, DateTimeKind.Utc).AddTicks(3334) },
                    { 4, "u-eddy-67015593", "Pendiente", new DateTime(2026, 3, 23, 0, 32, 40, 336, DateTimeKind.Utc).AddTicks(3335) },
                    { 1, "u-lizeth-60171101", "Aceptado", new DateTime(2026, 3, 23, 0, 32, 40, 336, DateTimeKind.Utc).AddTicks(2733) },
                    { 2, "u-lizeth-60171101", "Pendiente", new DateTime(2026, 3, 23, 0, 32, 40, 336, DateTimeKind.Utc).AddTicks(3334) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 3, "u-eddy-67015593" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 4, "u-eddy-67015593" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 1, "u-lizeth-60171101" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 2, "u-lizeth-60171101" });

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-eddy-67015593");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-lizeth-60171101");
        }
    }
}
