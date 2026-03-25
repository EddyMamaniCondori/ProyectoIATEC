using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgendaApi.Migrations
{
    /// <inheritdoc />
    public partial class ActualizarModeloEvento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Lugar",
                table: "Eventos",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Longitud",
                table: "Eventos",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Latitud",
                table: "Eventos",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Eventos",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 3, "u-eddy-67015593" },
                column: "FechaAsignacion",
                value: new DateTime(2026, 3, 23, 16, 44, 36, 685, DateTimeKind.Utc).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 4, "u-eddy-67015593" },
                column: "FechaAsignacion",
                value: new DateTime(2026, 3, 23, 16, 44, 36, 685, DateTimeKind.Utc).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 1, "u-lizeth-60171101" },
                column: "FechaAsignacion",
                value: new DateTime(2026, 3, 23, 16, 44, 36, 685, DateTimeKind.Utc).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 2, "u-lizeth-60171101" },
                column: "FechaAsignacion",
                value: new DateTime(2026, 3, 23, 16, 44, 36, 685, DateTimeKind.Utc).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-eddy-67015593",
                columns: new[] { "ConcurrencyStamp", "FechaRegistro", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d773d33b-38f1-4e99-8ef6-9d4fa7ec82c2", new DateTime(2026, 3, 23, 16, 44, 36, 694, DateTimeKind.Utc).AddTicks(8793), "AQAAAAIAAYagAAAAEDUH6HJXsUlwfJ+SraZPybKtQsLHfy42SfM6q/kiHC+N0qlArQhpOsyYVoHSfzGjbg==", "5e9068e2-4685-4b98-a1d6-36f969d1fd56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-lizeth-60171101",
                columns: new[] { "ConcurrencyStamp", "FechaRegistro", "PasswordHash", "SecurityStamp" },
                values: new object[] { "631ba1da-8668-4a4f-8044-5018f3adebb6", new DateTime(2026, 3, 23, 16, 44, 37, 190, DateTimeKind.Utc).AddTicks(7361), "AQAAAAIAAYagAAAAEO4mFI8cE6POTlX8JVgrSZbrJ6O3Y92KUvFFd5Dzke4xnKDmtQoEWGS+VLtTGWKpoQ==", "d9f17546-61f4-4edf-962b-e3cf2b9a59b7" });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 1,
                columns: new[] { "Descripcion", "Latitud", "Longitud" },
                values: new object[] { "", 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 2,
                columns: new[] { "Descripcion", "Latitud", "Longitud" },
                values: new object[] { "", 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 3,
                columns: new[] { "Descripcion", "Latitud", "Longitud" },
                values: new object[] { "", 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 4,
                columns: new[] { "Descripcion", "Latitud", "Longitud" },
                values: new object[] { "", 0.0, 0.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Lugar",
                table: "Eventos",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<double>(
                name: "Longitud",
                table: "Eventos",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<double>(
                name: "Latitud",
                table: "Eventos",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Eventos",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 3, "u-eddy-67015593" },
                column: "FechaAsignacion",
                value: new DateTime(2026, 3, 23, 0, 32, 40, 336, DateTimeKind.Utc).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 4, "u-eddy-67015593" },
                column: "FechaAsignacion",
                value: new DateTime(2026, 3, 23, 0, 32, 40, 336, DateTimeKind.Utc).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 1, "u-lizeth-60171101" },
                column: "FechaAsignacion",
                value: new DateTime(2026, 3, 23, 0, 32, 40, 336, DateTimeKind.Utc).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 2, "u-lizeth-60171101" },
                column: "FechaAsignacion",
                value: new DateTime(2026, 3, 23, 0, 32, 40, 336, DateTimeKind.Utc).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-eddy-67015593",
                columns: new[] { "ConcurrencyStamp", "FechaRegistro", "PasswordHash", "SecurityStamp" },
                values: new object[] { "450d9fef-ec72-4dce-8eab-909e7bfd68f7", new DateTime(2026, 3, 23, 0, 32, 40, 338, DateTimeKind.Utc).AddTicks(3289), "AQAAAAIAAYagAAAAEGGv/3MgAV5hR8t0w6pC4wjoJJLCp0sKFhDLpPvh8gMi0F3AnWAE3RQMgJvYU/vMEg==", "67811d61-3b3a-4313-bf3a-1f1191c14217" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-lizeth-60171101",
                columns: new[] { "ConcurrencyStamp", "FechaRegistro", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03854ea1-f3c3-45ae-957f-da8ec5093c2b", new DateTime(2026, 3, 23, 0, 32, 40, 377, DateTimeKind.Utc).AddTicks(4740), "AQAAAAIAAYagAAAAEHuqdkg/Uxl0a7b9Rh0y8Dq0OWxA/31bJuSHeSZyd/PEy+qznZNCn70ttNasmQBgLA==", "4f72a217-fc99-434c-9a18-4c6242f1f811" });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 1,
                columns: new[] { "Descripcion", "Latitud", "Longitud" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 2,
                columns: new[] { "Descripcion", "Latitud", "Longitud" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 3,
                columns: new[] { "Descripcion", "Latitud", "Longitud" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 4,
                columns: new[] { "Descripcion", "Latitud", "Longitud" },
                values: new object[] { null, null, null });
        }
    }
}
