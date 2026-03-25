using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgendaApi.Migrations
{
    /// <inheritdoc />
    public partial class AgregarVeinteUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 3, "u-eddy-67015593" },
                column: "FechaAsignacion",
                value: new DateTime(2026, 3, 24, 11, 5, 26, 489, DateTimeKind.Utc).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 4, "u-eddy-67015593" },
                column: "FechaAsignacion",
                value: new DateTime(2026, 3, 24, 11, 5, 26, 489, DateTimeKind.Utc).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 1, "u-lizeth-60171101" },
                column: "FechaAsignacion",
                value: new DateTime(2026, 3, 24, 11, 5, 26, 489, DateTimeKind.Utc).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 2, "u-lizeth-60171101" },
                column: "FechaAsignacion",
                value: new DateTime(2026, 3, 24, 11, 5, 26, 489, DateTimeKind.Utc).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-eddy-67015593",
                columns: new[] { "ConcurrencyStamp", "FechaRegistro", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f804301-561f-448d-83e4-ba606dfb1b85", new DateTime(2026, 3, 24, 11, 5, 26, 509, DateTimeKind.Utc).AddTicks(4963), "AQAAAAIAAYagAAAAECvcG3A72ek3trb+xWV1KJ+EniIA14r2j7iSs66Pyn35/4zDqp2PVBc91JFDD/Se3A==", "474c501d-c9f9-4f27-9343-0495286c44eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-lizeth-60171101",
                columns: new[] { "ConcurrencyStamp", "FechaRegistro", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df58e7b6-0849-424d-b700-98da040c130b", new DateTime(2026, 3, 24, 11, 5, 26, 840, DateTimeKind.Utc).AddTicks(4351), "AQAAAAIAAYagAAAAELAes86yvvN3GIN51Un29QFaWlxWwqZYK/vd9RTpJccTIFKlgM9bmHu8iPxVupRqVg==", "0eb06871-04a4-470d-bc3f-4b13626074f2" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Ape_materno", "Ape_paterno", "ConcurrencyStamp", "Email", "EmailConfirmed", "FechaRegistro", "Fecha_naci", "Foto_perfil", "LockoutEnabled", "LockoutEnd", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "u-ana-1004", 0, "Flores", "Martinez", "febf1d6a-83c8-45d9-a13c-1cea3eb2f13a", "ana@test.com", true, new DateTime(2026, 3, 24, 11, 5, 27, 663, DateTimeKind.Utc).AddTicks(9548), new DateTime(1994, 7, 14, 0, 0, 0, 0, DateTimeKind.Utc), "/images/user-default.png", false, null, "Ana", "ANA@TEST.COM", "ANA@TEST.COM", "AQAAAAIAAYagAAAAENAmrgek/BN5PjlLlewM1dgRTxec06/BuSOqSrBoFFT+L1KaqarLv6IuhhWYqkjQsQ==", "71234564", false, "14643eb0-52c3-4f5a-81e4-4e126dce759c", false, "ana@test.com" },
                    { "u-carlos-1003", 0, "Vargas", "Rodriguez", "491a6083-e8ad-4f5e-97ba-1f5715333a2d", "carlos@test.com", true, new DateTime(2026, 3, 24, 11, 5, 27, 453, DateTimeKind.Utc).AddTicks(2650), new DateTime(1988, 11, 5, 0, 0, 0, 0, DateTimeKind.Utc), "/images/user-default.png", false, null, "Carlos", "CARLOS@TEST.COM", "CARLOS@TEST.COM", "AQAAAAIAAYagAAAAEBbd2SWJL+a8/5CSmyYR0naI9h6fmylOJUKRNDf3midsUI6P/eW2mP/XHcRUYdMdyw==", "71234563", false, "af571ab6-3197-45db-90ec-7b3e91a18e29", false, "carlos@test.com" },
                    { "u-claudia-1016", 0, "Pascual", "Vidal", "39dd4397-1dc7-4751-99e7-6f0ccf97c89e", "claudia@test.com", true, new DateTime(2026, 3, 24, 11, 5, 29, 538, DateTimeKind.Utc).AddTicks(3952), new DateTime(1998, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), "/images/user-default.png", false, null, "Claudia", "CLAUDIA@TEST.COM", "CLAUDIA@TEST.COM", "AQAAAAIAAYagAAAAEHKpiUtKqsqI7Uq2tyx+kDbrXWTxcBr7tX4hDxMRnOOCx7GwjrB0ZN+Mpeocoj5Upw==", "71234576", false, "50422bc9-542d-42fb-acf7-7aa30efb3389", false, "claudia@test.com" },
                    { "u-david-1015", 0, "Hidalgo", "Cano", "61e0a2a1-af4b-4d54-b582-19e2b53282a2", "david@test.com", true, new DateTime(2026, 3, 24, 11, 5, 29, 420, DateTimeKind.Utc).AddTicks(2683), new DateTime(1986, 7, 21, 0, 0, 0, 0, DateTimeKind.Utc), "/images/user-default.png", false, null, "David", "DAVID@TEST.COM", "DAVID@TEST.COM", "AQAAAAIAAYagAAAAEPNx+lkBzOEsniNklqdWrhOKBjfJ5Ne1vENNAIeMc84iXrU3h1gZEQA0C0/isGVWqw==", "71234575", false, "629f59ee-ca42-4c18-b7d5-f2a681d84fb4", false, "david@test.com" },
                    { "u-elena-1008", 0, "Ortiz", "Castro", "0daf4433-68f8-4333-b76f-53659a640dc3", "elena@test.com", true, new DateTime(2026, 3, 24, 11, 5, 28, 450, DateTimeKind.Utc).AddTicks(4335), new DateTime(1993, 9, 3, 0, 0, 0, 0, DateTimeKind.Utc), "/images/user-default.png", false, null, "Elena", "ELENA@TEST.COM", "ELENA@TEST.COM", "AQAAAAIAAYagAAAAENucWhZnfFnwTG3XwSe9ZOBoF3sk5AgciYQHosPGX5wsbI4M4lXjhMeIHn/83GaSxA==", "71234568", false, "e45e68b2-a2ad-415b-9a31-5cd702c6d731", false, "elena@test.com" },
                    { "u-jorge-1007", 0, "Morales", "Ruiz", "10e3f5a3-942c-4611-849b-b33e995003ce", "jorge@test.com", true, new DateTime(2026, 3, 24, 11, 5, 28, 274, DateTimeKind.Utc).AddTicks(3162), new DateTime(1991, 6, 18, 0, 0, 0, 0, DateTimeKind.Utc), "/images/user-default.png", false, null, "Jorge", "JORGE@TEST.COM", "JORGE@TEST.COM", "AQAAAAIAAYagAAAAELhlnHtBNE7oJ4o8DhE2MS7rKJkUe0drXjXhvzfWNS7TMbXLFKrwgi1szwoVenS34g==", "71234567", false, "5870c3d4-84c5-4bfe-af27-91c80a436e2c", false, "jorge@test.com" },
                    { "u-juan-1001", 0, "Lopez", "Perez", "685d4753-e92c-4573-8b1d-38d328db8179", "juan@test.com", true, new DateTime(2026, 3, 24, 11, 5, 27, 87, DateTimeKind.Utc).AddTicks(2880), new DateTime(1990, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), "/images/user-default.png", false, null, "Juan", "JUAN@TEST.COM", "JUAN@TEST.COM", "AQAAAAIAAYagAAAAEPi3sz9uie7lMwNgr6vJ0Zoz+zDsD1cuv1hmWnLuanM0zuR4x6qppsnzWCsOMlkUvw==", "71234561", false, "18d11623-1f8b-49ce-b697-831ed40f37ea", false, "juan@test.com" },
                    { "u-laura-1012", 0, "Mendez", "Ibañez", "a189b715-1174-4dbb-b11d-7b5da8db141f", "laura@test.com", true, new DateTime(2026, 3, 24, 11, 5, 29, 54, DateTimeKind.Utc).AddTicks(5962), new DateTime(1999, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), "/images/user-default.png", false, null, "Laura", "LAURA@TEST.COM", "LAURA@TEST.COM", "AQAAAAIAAYagAAAAELUQwtj+x7Wul6CSdPAo6A84uuKaPFLQIWy0EAI6VtPB8rLV1Yzywge3X+w+NQjBNg==", "71234572", false, "b6cb6c7a-fa0a-4d6d-bd95-8e6ff8a40c02", false, "laura@test.com" },
                    { "u-lucia-1006", 0, "Torres", "Diaz", "ff09df98-fae0-40ea-8ff9-de1c9535fe9a", "lucia@test.com", true, new DateTime(2026, 3, 24, 11, 5, 28, 109, DateTimeKind.Utc).AddTicks(824), new DateTime(1997, 2, 28, 0, 0, 0, 0, DateTimeKind.Utc), "/images/user-default.png", false, null, "Lucia", "LUCIA@TEST.COM", "LUCIA@TEST.COM", "AQAAAAIAAYagAAAAECTGphNE6G2zqCdxzznfUmL/Fgt7/Ks08OhcfitbgxYqkkvaJlIY7sVY1JfBBwlecQ==", "71234566", false, "b6b556cd-608d-4950-b604-e11ec2c252bf", false, "lucia@test.com" },
                    { "u-luis-1009", 0, "Blanco", "Alvarez", "d22bdf34-daf9-4b27-8731-80ae4cb9879b", "luis@test.com", true, new DateTime(2026, 3, 24, 11, 5, 28, 604, DateTimeKind.Utc).AddTicks(8793), new DateTime(1989, 4, 12, 0, 0, 0, 0, DateTimeKind.Utc), "/images/user-default.png", false, null, "Luis", "LUIS@TEST.COM", "LUIS@TEST.COM", "AQAAAAIAAYagAAAAEKcLqdGZWnnZtO8uMiw39nT31JDQENBSUgCdn+EUFhP/aX1oYAOkgKBmhNvuE2Tckw==", "71234569", false, "9ba2e4fb-e728-4e79-84bf-d0c20a976564", false, "luis@test.com" },
                    { "u-maria-1002", 0, "Sosa", "Gomez", "a62dd9f8-6173-43ff-8afe-54cc3b1fc539", "maria@test.com", true, new DateTime(2026, 3, 24, 11, 5, 27, 269, DateTimeKind.Utc).AddTicks(8138), new DateTime(1992, 3, 22, 0, 0, 0, 0, DateTimeKind.Utc), "/images/user-default.png", false, null, "Maria", "MARIA@TEST.COM", "MARIA@TEST.COM", "AQAAAAIAAYagAAAAEEfnnyTQQ2s/ldA9F/eTxq2Q6gQH0lw1j5PM07tJjL1i3J3qUOpFpG457xkbwRHO8g==", "71234562", false, "0d04e3f0-5ddb-4587-b397-4cec033f21c4", false, "maria@test.com" },
                    { "u-marta-1014", 0, "Aguilar", "Ferrer", "838b4fde-b844-4c22-ae03-ea81ede486d4", "marta@test.com", true, new DateTime(2026, 3, 24, 11, 5, 29, 301, DateTimeKind.Utc).AddTicks(7109), new DateTime(1992, 11, 11, 0, 0, 0, 0, DateTimeKind.Utc), "/images/user-default.png", false, null, "Marta", "MARTA@TEST.COM", "MARTA@TEST.COM", "AQAAAAIAAYagAAAAEHBoB558J+sxSo0W45zGZCixlcuZElaO3lO7EZMdoP+4gMX5nHJjKOPe25tRbnVCMA==", "71234574", false, "6d2024ae-38b2-4036-89be-94945cadf175", false, "marta@test.com" },
                    { "u-miguel-1011", 0, "Delgado", "Moreno", "6e6def22-db9e-4600-840e-b33ee3538b23", "miguel@test.com", true, new DateTime(2026, 3, 24, 11, 5, 28, 931, DateTimeKind.Utc).AddTicks(3562), new DateTime(1987, 8, 8, 0, 0, 0, 0, DateTimeKind.Utc), "/images/user-default.png", false, null, "Miguel", "MIGUEL@TEST.COM", "MIGUEL@TEST.COM", "AQAAAAIAAYagAAAAEHPM9NQw46LJzVoQ5cEQPJN+AsFydmm1bIVgvgLh4SwTwNnnLwE1+UERhgBs1fdSjg==", "71234571", false, "b21d7246-cd4a-4032-82a4-9bcb442354ae", false, "miguel@test.com" },
                    { "u-oscar-1017", 0, "Campos", "Gallego", "a88b4080-5736-4d26-8830-7a7aee2cdc45", "oscar@test.com", true, new DateTime(2026, 3, 24, 11, 5, 29, 656, DateTimeKind.Utc).AddTicks(6872), new DateTime(1990, 2, 14, 0, 0, 0, 0, DateTimeKind.Utc), "/images/user-default.png", false, null, "Oscar", "OSCAR@TEST.COM", "OSCAR@TEST.COM", "AQAAAAIAAYagAAAAEA0ea1w/1Qxaf/b9FtPEXVU4eh6I2EcPrjLM4M4F08f3B0O26oefKOtqc/yGhPJPtQ==", "71234577", false, "f37e95f1-f0db-4bc0-834e-deffb1736c44", false, "oscar@test.com" },
                    { "u-pedro-1005", 0, "Ramos", "Sanchez", "51ad3a41-e670-4db1-9b00-3dfabc2cf3f5", "pedro@test.com", true, new DateTime(2026, 3, 24, 11, 5, 27, 871, DateTimeKind.Utc).AddTicks(324), new DateTime(1985, 12, 30, 0, 0, 0, 0, DateTimeKind.Utc), "/images/user-default.png", false, null, "Pedro", "PEDRO@TEST.COM", "PEDRO@TEST.COM", "AQAAAAIAAYagAAAAEOQWJgLvft4o+kQcXTM8EQIcqa91vs7OF+w7YVpq76G3108q2pHxkg0pu03J8RSHtg==", "71234565", false, "6a5c16de-5d7b-4050-ab28-915c6aabc379", false, "pedro@test.com" },
                    { "u-raul-1013", 0, "Serrano", "Gil", "e7790c08-fe8f-42a9-8f9e-04aeb46560d1", "raul@test.com", true, new DateTime(2026, 3, 24, 11, 5, 29, 187, DateTimeKind.Utc).AddTicks(6486), new DateTime(1994, 5, 30, 0, 0, 0, 0, DateTimeKind.Utc), "/images/user-default.png", false, null, "Raul", "RAUL@TEST.COM", "RAUL@TEST.COM", "AQAAAAIAAYagAAAAECS72g6OCDHRP/zesho3SpEmAr3HXmuHjLC6dkid5HyXSUeF3kgFSZPN/yIENWYkwA==", "71234573", false, "ee24cf5d-07a5-4327-9b98-3b0654406968", false, "raul@test.com" },
                    { "u-silvia-1018", 0, "Fuentes", "Peña", "4b7cccea-7acf-47ae-a6be-20d017e37b80", "silvia@test.com", true, new DateTime(2026, 3, 24, 11, 5, 30, 70, DateTimeKind.Utc).AddTicks(4636), new DateTime(1995, 8, 19, 0, 0, 0, 0, DateTimeKind.Utc), "/images/user-default.png", false, null, "Silvia", "SILVIA@TEST.COM", "SILVIA@TEST.COM", "AQAAAAIAAYagAAAAEIA/yQF2+pqGIDdNArhNQY/0zTbqYLJMG2eqw7I+F6nEgkgVIwVAgnrpAJqZl9r39w==", "71234578", false, "39d57c31-e2b8-4b70-99c2-1f6b5aac524b", false, "silvia@test.com" },
                    { "u-sofia-1010", 0, "Navarro", "Jimenez", "56cdda5f-84a7-42e9-960a-b799c5df650b", "sofia@test.com", true, new DateTime(2026, 3, 24, 11, 5, 28, 802, DateTimeKind.Utc).AddTicks(3663), new DateTime(1996, 10, 25, 0, 0, 0, 0, DateTimeKind.Utc), "/images/user-default.png", false, null, "Sofia", "SOFIA@TEST.COM", "SOFIA@TEST.COM", "AQAAAAIAAYagAAAAEI1/nxsTMj6hMxG5icB0EvxLsRK673h8OxNgiNaMJUorpGFFFTJM5aTtKhXTKdkW3Q==", "71234570", false, "03b53215-6447-4d2e-9dab-6128113d35ae", false, "sofia@test.com" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-ana-1004");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-carlos-1003");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-claudia-1016");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-david-1015");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-elena-1008");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-jorge-1007");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-juan-1001");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-laura-1012");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-lucia-1006");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-luis-1009");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-maria-1002");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-marta-1014");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-miguel-1011");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-oscar-1017");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-pedro-1005");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-raul-1013");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-silvia-1018");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-sofia-1010");

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
        }
    }
}
