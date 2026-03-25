using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgendaApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedFinalConInvitaciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 3, "u-eddy-67015593" },
                column: "FechaAsignacion",
                value: new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 4, "u-eddy-67015593" },
                columns: new[] { "Estado", "FechaAsignacion" },
                values: new object[] { "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5568) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 1, "u-lizeth-60171101" },
                column: "FechaAsignacion",
                value: new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 2, "u-lizeth-60171101" },
                columns: new[] { "Estado", "FechaAsignacion" },
                values: new object[] { "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5722) });

            migrationBuilder.InsertData(
                table: "Agendas",
                columns: new[] { "Id_evento", "Id_usuario", "Estado", "FechaAsignacion" },
                values: new object[,]
                {
                    { 1, "u-ana-1004", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5717) },
                    { 2, "u-ana-1004", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5884) },
                    { 3, "u-ana-1004", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5896) },
                    { 4, "u-ana-1004", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5907) },
                    { 1, "u-carlos-1003", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5716) },
                    { 2, "u-carlos-1003", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5881) },
                    { 3, "u-carlos-1003", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5894) },
                    { 4, "u-carlos-1003", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5906) },
                    { 1, "u-eddy-67015593", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(2838) },
                    { 2, "u-eddy-67015593", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5564) },
                    { 1, "u-juan-1001", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5683) },
                    { 2, "u-juan-1001", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5877) },
                    { 3, "u-juan-1001", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5891) },
                    { 4, "u-juan-1001", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5903) },
                    { 3, "u-lizeth-60171101", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5889) },
                    { 4, "u-lizeth-60171101", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5901) },
                    { 1, "u-lucia-1006", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5721) },
                    { 2, "u-lucia-1006", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5888) },
                    { 3, "u-lucia-1006", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5899) },
                    { 4, "u-lucia-1006", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5910) },
                    { 1, "u-maria-1002", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5714) },
                    { 2, "u-maria-1002", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5879) },
                    { 3, "u-maria-1002", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5892) },
                    { 4, "u-maria-1002", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5904) },
                    { 1, "u-pedro-1005", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5719) },
                    { 2, "u-pedro-1005", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5886) },
                    { 3, "u-pedro-1005", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5898) },
                    { 4, "u-pedro-1005", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5909) }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-ana-1004",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "55e096b0-f3db-4726-aff7-f8c6b5790ffb", "ana@gmail.com", new DateTime(2026, 3, 25, 16, 35, 56, 648, DateTimeKind.Utc).AddTicks(9486), "ANA@GMAIL.COM", "ANA@GMAIL.COM", "AQAAAAIAAYagAAAAEIn5sfzg3wzL0NyGoO3Z0BWuOv7B0z5yeUrqpr7J0FqlTCBCkRxy/tNB5jfsLLEVFQ==", "71013ffe-ae79-44e8-a783-797012cf73fb", "ana@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-carlos-1003",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e9e4598c-ce98-4ac3-b957-079db2a959af", "carlos@gmail.com", new DateTime(2026, 3, 25, 16, 35, 56, 471, DateTimeKind.Utc).AddTicks(9209), "CARLOS@GMAIL.COM", "CARLOS@GMAIL.COM", "AQAAAAIAAYagAAAAEAcNmE7IUZ05i+H+yHdn1iPqfQTU6G9H/djxZJJwsnYd6DxZIAWaCsDqIzlM7Ottpg==", "becafb63-0fc8-46a7-b36a-64cdc460e219", "carlos@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-claudia-1016",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "226726eb-c07e-47a9-8dbc-cf256f5c7db2", "claudia@gmail.com", new DateTime(2026, 3, 25, 16, 35, 58, 331, DateTimeKind.Utc).AddTicks(7260), "CLAUDIA@GMAIL.COM", "CLAUDIA@GMAIL.COM", "AQAAAAIAAYagAAAAEF349DhBuuVmcAwa2JvHFFC6/+MLUQL/F1Me659GmSVm8OCO2qOOHa2f0nNfzm49Gw==", "bcf6729a-89e1-40ae-a248-bb0003793da8", "claudia@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-david-1015",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "cc63eef9-49d3-4d90-81a8-11f93cbc64d1", "david@gmail.com", new DateTime(2026, 3, 25, 16, 35, 58, 213, DateTimeKind.Utc).AddTicks(9190), "DAVID@GMAIL.COM", "DAVID@GMAIL.COM", "AQAAAAIAAYagAAAAEGXnCmaV82CChD9Ph7Q0v2oh8AkviUq/l+QSFbMVl44BQDJw+Fke4x7P6BdztdqnTQ==", "03352fbb-5957-4981-b789-98224caf48d9", "david@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-eddy-67015593",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f8eac2e4-25e1-4c14-9fd5-e1e369eb5ac4", "eddy@gmail.com", new DateTime(2026, 3, 25, 16, 35, 55, 518, DateTimeKind.Utc).AddTicks(5852), "EDDY@GMAIL.COM", "EDDY@GMAIL.COM", "AQAAAAIAAYagAAAAENdPfFFiuviRatagULTvLT0P6JOeg0PjXHrtUAJXX5oFni/32Rzcyt5we27ua4eLAQ==", "53f27aa3-4198-4e81-9368-9de4e7cb91a5", "eddy@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-elena-1008",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "abd3e5b7-e4b1-4366-977e-34519b2aaa40", "elena@gmail.com", new DateTime(2026, 3, 25, 16, 35, 57, 335, DateTimeKind.Utc).AddTicks(7936), "ELENA@GMAIL.COM", "ELENA@GMAIL.COM", "AQAAAAIAAYagAAAAEMZAUMt27SIi88IutOGoajDbaO7X8Rm8Vqt5lCvQB5tP+jNeKzWIKtPLFx81SbS8Dg==", "2ccafc22-a8da-4831-bbb1-ffd753dec591", "elena@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-jorge-1007",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b0765ccb-b755-4191-9ab8-2ec0b9ff2bf0", "jorge@gmail.com", new DateTime(2026, 3, 25, 16, 35, 57, 175, DateTimeKind.Utc).AddTicks(3667), "JORGE@GMAIL.COM", "JORGE@GMAIL.COM", "AQAAAAIAAYagAAAAEMzhCJnBrBDUSTjIt5/G+exksd8wNF5Zbnb0qSZsY8xkSiYQ3tM++6WkpatAqsEy4g==", "45977620-1581-4c1b-bcb8-036cb82eb1c8", "jorge@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-juan-1001",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0152a203-79b0-48fc-bbf9-8be8f668140d", "juan@gmail.com", new DateTime(2026, 3, 25, 16, 35, 56, 51, DateTimeKind.Utc).AddTicks(3126), "JUAN@GMAIL.COM", "JUAN@GMAIL.COM", "AQAAAAIAAYagAAAAEDT86NlQSShIKiB0QoGSF1iKYK3axc7E2xq3kmwwsHctDnkGsC1NabRWTLQ0K8uQHQ==", "6f20c852-340c-412d-9ab5-af54bfab30b9", "juan@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-laura-1012",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4563a19c-fcc3-43a2-a5a0-3a21d13074d2", "laura@gmail.com", new DateTime(2026, 3, 25, 16, 35, 57, 823, DateTimeKind.Utc).AddTicks(7088), "LAURA@GMAIL.COM", "LAURA@GMAIL.COM", "AQAAAAIAAYagAAAAEFb1z7PEehev/r6AcuSL5vHLw8JcBVmHgPWUwPXFbB1MqFsUxq1BCODirfesM/TjGA==", "89f01b1d-aebf-4dec-b9a7-ae419b84c701", "laura@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-lizeth-60171101",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0ec22ce9-0366-49f3-ae3f-a3934d2a4881", "lizeth@gmail.com", new DateTime(2026, 3, 25, 16, 35, 55, 771, DateTimeKind.Utc).AddTicks(3129), "LIZETH@GMAIL.COM", "LIZETH@GMAIL.COM", "AQAAAAIAAYagAAAAECVs/WuE1V724KHKKmQNxkQ3hRfk53EjlPYzuimAQR37TpIc4sw8PODcpOCLxmL1GQ==", "96cf5af6-98c6-48fc-9be7-4e0bda5a1088", "lizeth@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-lucia-1006",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "145cb870-f1da-49f9-9a34-30a808acdc12", "lucia@gmail.com", new DateTime(2026, 3, 25, 16, 35, 57, 17, DateTimeKind.Utc).AddTicks(1166), "LUCIA@GMAIL.COM", "LUCIA@GMAIL.COM", "AQAAAAIAAYagAAAAELATQUXKTBtz9Lv+Zt7vTNGkUoVfV43wzpIw/TONBnkT6/Ngjzid++WV151I+sl8vw==", "beb6f307-036f-4eeb-a887-94461a86f688", "lucia@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-luis-1009",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "db5bcb5f-c1c2-4f82-9819-3073ac99635f", "luis@gmail.com", new DateTime(2026, 3, 25, 16, 35, 57, 486, DateTimeKind.Utc).AddTicks(4027), "LUIS@GMAIL.COM", "LUIS@GMAIL.COM", "AQAAAAIAAYagAAAAEAckUDSLrxheIZ9Ce1FNHEm6qiAAQamItgNeyoCyn76rn+M6elJUw6I5pxmXaV7UlQ==", "c4bccd7e-7f84-45ad-857a-b337f396aa4e", "luis@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-maria-1002",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "39a99902-4358-4b3c-a60f-1ba633f609a2", "maria@gmail.com", new DateTime(2026, 3, 25, 16, 35, 56, 250, DateTimeKind.Utc).AddTicks(861), "MARIA@GMAIL.COM", "MARIA@GMAIL.COM", "AQAAAAIAAYagAAAAEGbXEOkGYJPZg2JFuz/xJkK+JaM7jOIEU2VnuLNv1P7mmBHJdLfdPOsS4XFZP/2o1g==", "c4a69067-4f53-495d-aa5c-4f6c463d0f4d", "maria@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-marta-1014",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5ddd8b5d-a670-49b5-9d80-2e23a58ea0f9", "marta@gmail.com", new DateTime(2026, 3, 25, 16, 35, 58, 70, DateTimeKind.Utc).AddTicks(4285), "MARTA@GMAIL.COM", "MARTA@GMAIL.COM", "AQAAAAIAAYagAAAAENcnc8SiP1jQzR+IiqP1aIn1E0oBm5OC53Z20BBA6RZu2W3ceReXnW2TIz3Iwy48fg==", "59930f68-946a-44f5-842e-3cc0ef130f43", "marta@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-miguel-1011",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "feea6b15-4019-4ae8-a3eb-1303b071ed89", "miguel@gmail.com", new DateTime(2026, 3, 25, 16, 35, 57, 708, DateTimeKind.Utc).AddTicks(9279), "MIGUEL@GMAIL.COM", "MIGUEL@GMAIL.COM", "AQAAAAIAAYagAAAAEDb0xJq068nIYrVaK/JaQkLd/JH9wcehVVK6cASkGHof6vD+XxteBzVhHll+bXjo9w==", "27784ef4-478a-4500-b533-075687ba2e7e", "miguel@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-oscar-1017",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "91a9e3b1-b4a6-4598-a25b-8f54253dc87e", "oscar@gmail.com", new DateTime(2026, 3, 25, 16, 35, 58, 442, DateTimeKind.Utc).AddTicks(2924), "OSCAR@GMAIL.COM", "OSCAR@GMAIL.COM", "AQAAAAIAAYagAAAAEJqK/1hzb31VMtqT41g67O+K6Q/6GZyV4lGEuDg1m5GZBxOv+jhlIdTxmpDRz8dY0g==", "e02b102f-b5f5-45b9-ba9f-76e5f9b19d17", "oscar@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-pedro-1005",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8c5d7846-f977-44e4-9200-ae36b005dc8e", "pedro@gmail.com", new DateTime(2026, 3, 25, 16, 35, 56, 844, DateTimeKind.Utc).AddTicks(8014), "PEDRO@GMAIL.COM", "PEDRO@GMAIL.COM", "AQAAAAIAAYagAAAAEF/t/kGrnYMvjR0d+tckr2Tpt8kYB960lvkh0IEgKNrAQjt4PMYQqGH27vwHXkJ9DA==", "7794a8c3-c514-45e5-80c7-640079b48d59", "pedro@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-raul-1013",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0d879aff-37de-4e3f-a989-6174de021522", "raul@gmail.com", new DateTime(2026, 3, 25, 16, 35, 57, 944, DateTimeKind.Utc).AddTicks(286), "RAUL@GMAIL.COM", "RAUL@GMAIL.COM", "AQAAAAIAAYagAAAAEFxLWyp8IBHhij2sgNLqiDuXCHxVYhdHSSWinA4rNCz+mj8475F9pk3clnywUYsdFA==", "127607f8-5dc0-4c6f-8ad7-a4f9faba4d91", "raul@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-silvia-1018",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2ca0b493-39ea-4af0-8b02-d518cd706b3c", "silvia@gmail.com", new DateTime(2026, 3, 25, 16, 35, 58, 553, DateTimeKind.Utc).AddTicks(1336), "SILVIA@GMAIL.COM", "SILVIA@GMAIL.COM", "AQAAAAIAAYagAAAAEMrSwZ/7CIfNdWnRz/DMemwE7jf/eCqgThsWFJ7UOASF9PFJyWmOu3kKTlWOMi71Tw==", "87c3edd1-9417-4472-bb65-e7ec278dd292", "silvia@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-sofia-1010",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b0b1de73-fae8-47e8-b4db-22b9268cc092", "sofia@gmail.com", new DateTime(2026, 3, 25, 16, 35, 57, 600, DateTimeKind.Utc).AddTicks(2850), "SOFIA@GMAIL.COM", "SOFIA@GMAIL.COM", "AQAAAAIAAYagAAAAEJsW3XIuPFqmNfUVO0f2aoN1G0qlo8kKZOAopMFwtyxHQyBMVCCIZflDznblZAq9pg==", "82c0d3bb-64a2-4c70-80d7-d0526530d66e", "sofia@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 1,
                columns: new[] { "Descripcion", "Hora_finalizacion", "Imagen", "Latitud", "Longitud", "Lugar", "Nombre" },
                values: new object[] { "Presentación final de la agenda 3D.", new TimeSpan(0, 12, 0, 0, 0), "/uploads/conferencia.jpg", -16.492000000000001, -68.192099999999996, "UPEA - El Alto", "Lanzamiento Proyecto IATEC" });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 2,
                columns: new[] { "Descripcion", "Hora_finalizacion", "Hora_inicio", "Latitud", "Longitud", "Lugar", "Nombre" },
                values: new object[] { "Ajustes de API y base de datos.", new TimeSpan(0, 16, 0, 0, 0), new TimeSpan(0, 14, 0, 0, 0), -16.4955, -68.135300000000001, "San Francisco - La Paz", "Reunión Técnica Backend" });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 3,
                columns: new[] { "Descripcion", "Fecha_finalizacion", "Fecha_inicio", "Hora_finalizacion", "Hora_inicio", "Id_usuario", "Imagen", "Latitud", "Longitud", "Lugar", "Nombre" },
                values: new object[] { "Celebración del hito del proyecto.", new DateTime(2026, 3, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 3, 26, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 23, 0, 0, 0), new TimeSpan(0, 20, 0, 0, 0), "u-eddy-67015593", "/uploads/cena_fin_de_mes.jpg", -16.5411, -68.080500000000001, "Calacoto - Zona Sur", "Cena de Confraternización" });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 4,
                columns: new[] { "Descripcion", "Hora_finalizacion", "Id_usuario", "Imagen", "Latitud", "Longitud", "Lugar", "Nombre" },
                values: new object[] { "Feedback sobre la interacción de la agenda.", new TimeSpan(0, 11, 30, 0, 0), "u-eddy-67015593", "/uploads/esteban.jpg", -16.5015, -68.129999999999995, "Teleférico Morado", "Revisión de UI/UX 3D" });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id_evento", "Descripcion", "Fecha_finalizacion", "Fecha_inicio", "Hora_finalizacion", "Hora_inicio", "Id_usuario", "Imagen", "Latitud", "Longitud", "Lugar", "Nombre", "Tipo" },
                values: new object[,]
                {
                    { 5, "Desestres del equipo.", new DateTime(2026, 3, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 3, 27, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 21, 0, 0, 0), new TimeSpan(0, 19, 0, 0, 0), "u-eddy-67015593", null, -16.510000000000002, -68.200000000000003, "Cancha 5 - El Alto", "Partido de Futbol", "Exclusivo" },
                    { 6, "Celebración anual.", new DateTime(2026, 3, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 3, 28, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 16, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "u-lizeth-60171101", "/uploads/aniversario.png", -16.511299999999999, -68.123500000000007, "Multicine LP", "Aniversario de la Empresa", "Compartido" },
                    { 7, "Capacitación.", new DateTime(2026, 3, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 3, 29, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 18, 0, 0, 0), new TimeSpan(0, 14, 0, 0, 0), "u-lizeth-60171101", "/uploads/conferencia.jpg", -16.496500000000001, -68.134, "Hotel Presidente", "Taller de Liderazgo", "Compartido" },
                    { 8, "Defensa de grado.", new DateTime(2026, 3, 25, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 3, 25, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 16, 0, 0, 0), new TimeSpan(0, 14, 0, 0, 0), "u-lizeth-60171101", null, -16.504200000000001, -68.130200000000002, "Auditorio UMSA", "Presentación de Tesis", "Compartido" },
                    { 9, "Feedback grupal.", new DateTime(2026, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 16, 30, 0, 0), new TimeSpan(0, 15, 0, 0, 0), "u-lizeth-60171101", "/uploads/esteban.jpg", -16.510999999999999, -68.126499999999993, "Plaza Abaroa", "Coaching de Equipo", "Exclusivo" },
                    { 10, "Limpieza anual.", new DateTime(2026, 3, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 3, 27, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 11, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0), "u-lizeth-60171101", null, -16.507999999999999, -68.128, "Clínica Dental Sopocachi", "Cita Dental", "Exclusivo" },
                    { 11, "Evento SCZ", new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), "u-juan-1001", "/uploads/conferencia.jpg", -17.7942, -63.192999999999998, "Expocruz SCZ", "Conferencia Tech Latam", "Compartido" },
                    { 12, "Demo SCZ", new DateTime(2026, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 11, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0), "u-juan-1001", null, -17.765000000000001, -63.1905, "Hotel Los Tajibos", "Demo de Producto", "Exclusivo" },
                    { 13, "Almuerzo SCZ", new DateTime(2026, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 14, 0, 0, 0), new TimeSpan(0, 12, 30, 0, 0), "u-juan-1001", "/uploads/cena_fin_de_mes.jpg", -17.768000000000001, -63.185000000000002, "Punto G", "Almuerzo Ejecutivo", "Compartido" },
                    { 14, "Legal SCZ", new DateTime(2026, 4, 7, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 4, 7, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 16, 0, 0, 0), new TimeSpan(0, 15, 0, 0, 0), "u-juan-1001", null, -17.7621, -63.192500000000003, "Torre Duo", "Revisión de Contrato", "Exclusivo" },
                    { 15, "Online SCZ", new DateTime(2026, 4, 8, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 4, 8, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 16, 0, 0, 0), "u-juan-1001", "/uploads/conferencia.jpg", -17.783300000000001, -63.182099999999998, "Online", "Webinar de Seguridad", "Compartido" },
                    { 16, "Cena CBBA", new DateTime(2026, 3, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 3, 30, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 21, 0, 0, 0), new TimeSpan(0, 19, 0, 0, 0), "u-maria-1002", "/uploads/cena_fin_de_mes.jpg", -17.375, -66.155000000000001, "La Recoleta", "Cena Fin de Mes", "Compartido" },
                    { 17, "Arte CBBA", new DateTime(2026, 4, 2, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 4, 2, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 20, 0, 0, 0), new TimeSpan(0, 18, 0, 0, 0), "u-maria-1002", "/uploads/aniversario.png", -17.389099999999999, -66.158000000000001, "El Prado", "Taller de Arte", "Compartido" },
                    { 18, "Colegio CBBA", new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 18, 30, 0, 0), new TimeSpan(0, 17, 0, 0, 0), "u-maria-1002", null, -17.367999999999999, -66.162000000000006, "Colegio Maryknoll", "Reunión de Padres", "Exclusivo" },
                    { 19, "MKT CBBA", new DateTime(2026, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 12, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), "u-maria-1002", "/uploads/conferencia.jpg", -17.3855, -66.153000000000006, "Edificio Los Tiempos", "Estudio de Mercado", "Exclusivo" },
                    { 20, "Ventas CBBA", new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 12, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "u-maria-1002", null, -17.381, -66.155500000000004, "Plaza de las Banderas", "Cita con Cliente", "Exclusivo" },
                    { 21, "Salud Sucre", new DateTime(2026, 3, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 3, 27, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), "u-carlos-1003", null, -19.047499999999999, -65.259500000000003, "Plaza 25 de Mayo", "Cita Dental Carlos", "Exclusivo" },
                    { 22, "Deporte Potosi", new DateTime(2026, 3, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 3, 29, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 20, 0, 0, 0), new TimeSpan(0, 18, 0, 0, 0), "u-carlos-1003", "/uploads/esteban.jpg", -19.578499999999998, -65.751800000000003, "Estadio Victor Agustin Ugarte", "Partido de Futbol Fin de Semana", "Compartido" },
                    { 23, "Negocios Sucre", new DateTime(2026, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 12, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0), "u-carlos-1003", "/uploads/conferencia.jpg", -19.0425, -65.254999999999995, "Corte Suprema", "Reunión de Socios", "Exclusivo" },
                    { 24, "Fiesta Sucre", new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 20, 0, 0, 0), new TimeSpan(0, 15, 0, 0, 0), "u-carlos-1003", "/uploads/aniversario.png", -19.038499999999999, -65.263099999999994, "Parque Bolivar", "Cumpleaños Carlos JR", "Compartido" },
                    { 25, "Finanzas", new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 16, 0, 0, 0), "u-carlos-1003", null, -19.039999999999999, -65.260000000000005, "Online", "Revisión de Inversiones", "Exclusivo" },
                    { 26, "Yoga", new DateTime(2026, 3, 26, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 3, 26, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 9, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), "u-ana-1004", null, -16.5, -68.120000000000005, "Gimnasio", "Clase de Yoga Ana", "Compartido" },
                    { 27, "Socios", new DateTime(2026, 3, 27, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 3, 27, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 12, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "u-pedro-1005", "/uploads/esteban.jpg", -17.780000000000001, -63.18, "Oficina Pedro", "Reunión Pedro y Socios", "Exclusivo" },
                    { 28, "Arte", new DateTime(2026, 3, 28, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 3, 28, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 21, 0, 0, 0), new TimeSpan(0, 19, 0, 0, 0), "u-lucia-1006", "/uploads/aniversario.png", -16.489999999999998, -68.140000000000001, "Galería Moderna", "Exposición de Arte Lucia", "Compartido" },
                    { 29, "Prov", new DateTime(2026, 3, 29, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 3, 29, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 12, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0), "u-jorge-1007", "/uploads/conferencia.jpg", -17.379999999999999, -66.159999999999997, "Online", "Reunión Jorge y Proveedores", "Exclusivo" },
                    { 30, "B-Day", new DateTime(2026, 3, 30, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 3, 30, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 22, 0, 0, 0), new TimeSpan(0, 20, 0, 0, 0), "u-elena-1008", "/uploads/cena_fin_de_mes.jpg", -19.030000000000001, -65.25, "Restaurante Italia", "Cena Cumpleaños Elena", "Compartido" },
                    { 31, "Futbol", new DateTime(2026, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 3, 31, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 20, 0, 0, 0), new TimeSpan(0, 18, 0, 0, 0), "u-luis-1009", "/uploads/esteban.jpg", -17.77, -63.170000000000002, "Cancha 2", "Partido Futbol Luis", "Compartido" },
                    { 32, "Webinar", new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 16, 0, 0, 0), "u-sofia-1010", "/uploads/conferencia.jpg", -16.52, -68.109999999999999, "Zoom", "Webinar Sofia Innovación", "Compartido" },
                    { 33, "MKT", new DateTime(2026, 4, 2, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 4, 2, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 11, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0), "u-miguel-1011", null, -17.390000000000001, -66.150000000000006, "Oficina Miguel", "Reunión Miguel Marketing", "Exclusivo" },
                    { 34, "Love", new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 22, 0, 0, 0), new TimeSpan(0, 20, 0, 0, 0), "u-laura-1012", "/uploads/aniversario.png", -17.789999999999999, -63.189999999999998, "Restaurante Romance", "Aniversario Laura y Pedro", "Compartido" },
                    { 35, "Conf", new DateTime(2026, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 9, 0, 0, 0), "u-raul-1013", "/uploads/conferencia.jpg", -16.5, -68.129999999999995, "Auditorio", "Conferencia Raul Liderazgo", "Compartido" },
                    { 36, "CRM", new DateTime(2026, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 12, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "u-marta-1014", "/uploads/esteban.jpg", -17.760000000000002, -63.200000000000003, "Online", "Reunión Marta Clientes", "Exclusivo" },
                    { 37, "Cena", new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 4, 6, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 21, 0, 0, 0), new TimeSpan(0, 19, 0, 0, 0), "u-david-1015", "/uploads/cena_fin_de_mes.jpg", -17.370000000000001, -66.140000000000001, "Pizzería Sony", "Cena Fin Mes David", "Compartido" },
                    { 38, "Prov", new DateTime(2026, 4, 7, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 4, 7, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 11, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0), "u-claudia-1016", "/uploads/conferencia.jpg", -16.48, -68.150000000000006, "Oficina Claudia", "Reunión Claudia Proveedores", "Exclusivo" },
                    { 39, "Deporte", new DateTime(2026, 4, 8, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 4, 8, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 20, 0, 0, 0), new TimeSpan(0, 18, 0, 0, 0), "u-oscar-1017", "/uploads/esteban.jpg", -17.75, -63.159999999999997, "Cancha 1", "Partido Futbol Oscar", "Compartido" },
                    { 40, "Sales", new DateTime(2026, 4, 9, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 4, 9, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 16, 0, 0, 0), "u-silvia-1018", "/uploads/conferencia.jpg", -19.050000000000001, -65.239999999999995, "Zoom", "Webinar Silvia Ventas", "Compartido" }
                });

            migrationBuilder.InsertData(
                table: "Agendas",
                columns: new[] { "Id_evento", "Id_usuario", "Estado", "FechaAsignacion" },
                values: new object[,]
                {
                    { 5, "u-ana-1004", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5943) },
                    { 6, "u-ana-1004", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5955) },
                    { 7, "u-ana-1004", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5966) },
                    { 8, "u-ana-1004", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5977) },
                    { 9, "u-ana-1004", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5988) },
                    { 10, "u-ana-1004", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(6000) },
                    { 26, "u-ana-1004", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5657) },
                    { 5, "u-carlos-1003", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5942) },
                    { 6, "u-carlos-1003", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5954) },
                    { 7, "u-carlos-1003", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5965) },
                    { 8, "u-carlos-1003", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5976) },
                    { 9, "u-carlos-1003", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5987) },
                    { 10, "u-carlos-1003", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5998) },
                    { 21, "u-carlos-1003", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5649) },
                    { 22, "u-carlos-1003", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5651) },
                    { 23, "u-carlos-1003", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5653) },
                    { 24, "u-carlos-1003", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5654) },
                    { 25, "u-carlos-1003", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5656) },
                    { 38, "u-claudia-1016", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5677) },
                    { 37, "u-david-1015", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5675) },
                    { 5, "u-eddy-67015593", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5569) },
                    { 6, "u-eddy-67015593", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5948) },
                    { 7, "u-eddy-67015593", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5960) },
                    { 8, "u-eddy-67015593", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5971) },
                    { 9, "u-eddy-67015593", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5982) },
                    { 10, "u-eddy-67015593", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5993) },
                    { 30, "u-elena-1008", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5664) },
                    { 29, "u-jorge-1007", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5662) },
                    { 5, "u-juan-1001", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5914) },
                    { 6, "u-juan-1001", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5950) },
                    { 7, "u-juan-1001", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5962) },
                    { 8, "u-juan-1001", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5972) },
                    { 9, "u-juan-1001", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5984) },
                    { 10, "u-juan-1001", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5995) },
                    { 11, "u-juan-1001", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5579) },
                    { 12, "u-juan-1001", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5581) },
                    { 13, "u-juan-1001", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5582) },
                    { 14, "u-juan-1001", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5637) },
                    { 15, "u-juan-1001", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5639) },
                    { 34, "u-laura-1012", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5670) },
                    { 5, "u-lizeth-60171101", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5912) },
                    { 6, "u-lizeth-60171101", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5571) },
                    { 7, "u-lizeth-60171101", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5573) },
                    { 8, "u-lizeth-60171101", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5574) },
                    { 9, "u-lizeth-60171101", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5576) },
                    { 10, "u-lizeth-60171101", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5578) },
                    { 5, "u-lucia-1006", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5947) },
                    { 6, "u-lucia-1006", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5958) },
                    { 7, "u-lucia-1006", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5969) },
                    { 8, "u-lucia-1006", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5981) },
                    { 9, "u-lucia-1006", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5991) },
                    { 10, "u-lucia-1006", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(6003) },
                    { 28, "u-lucia-1006", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5661) },
                    { 31, "u-luis-1009", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5665) },
                    { 5, "u-maria-1002", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5940) },
                    { 6, "u-maria-1002", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5951) },
                    { 7, "u-maria-1002", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5963) },
                    { 8, "u-maria-1002", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5974) },
                    { 9, "u-maria-1002", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5985) },
                    { 10, "u-maria-1002", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5996) },
                    { 16, "u-maria-1002", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5641) },
                    { 17, "u-maria-1002", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5643) },
                    { 18, "u-maria-1002", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5644) },
                    { 19, "u-maria-1002", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5646) },
                    { 20, "u-maria-1002", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5648) },
                    { 36, "u-marta-1014", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5673) },
                    { 33, "u-miguel-1011", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5669) },
                    { 39, "u-oscar-1017", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5679) },
                    { 5, "u-pedro-1005", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5945) },
                    { 6, "u-pedro-1005", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5957) },
                    { 7, "u-pedro-1005", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5968) },
                    { 8, "u-pedro-1005", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5979) },
                    { 9, "u-pedro-1005", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5990) },
                    { 10, "u-pedro-1005", "Pendiente", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(6001) },
                    { 27, "u-pedro-1005", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5659) },
                    { 35, "u-raul-1013", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5672) },
                    { 40, "u-silvia-1018", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5680) },
                    { 32, "u-sofia-1010", "Aceptado", new DateTime(2026, 3, 25, 16, 35, 55, 478, DateTimeKind.Utc).AddTicks(5667) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 1, "u-ana-1004" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 2, "u-ana-1004" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 3, "u-ana-1004" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 4, "u-ana-1004" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 5, "u-ana-1004" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 6, "u-ana-1004" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 7, "u-ana-1004" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 8, "u-ana-1004" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 9, "u-ana-1004" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 10, "u-ana-1004" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 26, "u-ana-1004" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 1, "u-carlos-1003" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 2, "u-carlos-1003" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 3, "u-carlos-1003" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 4, "u-carlos-1003" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 5, "u-carlos-1003" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 6, "u-carlos-1003" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 7, "u-carlos-1003" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 8, "u-carlos-1003" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 9, "u-carlos-1003" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 10, "u-carlos-1003" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 21, "u-carlos-1003" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 22, "u-carlos-1003" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 23, "u-carlos-1003" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 24, "u-carlos-1003" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 25, "u-carlos-1003" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 38, "u-claudia-1016" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 37, "u-david-1015" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 1, "u-eddy-67015593" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 2, "u-eddy-67015593" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 5, "u-eddy-67015593" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 6, "u-eddy-67015593" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 7, "u-eddy-67015593" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 8, "u-eddy-67015593" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 9, "u-eddy-67015593" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 10, "u-eddy-67015593" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 30, "u-elena-1008" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 29, "u-jorge-1007" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 1, "u-juan-1001" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 2, "u-juan-1001" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 3, "u-juan-1001" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 4, "u-juan-1001" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 5, "u-juan-1001" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 6, "u-juan-1001" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 7, "u-juan-1001" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 8, "u-juan-1001" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 9, "u-juan-1001" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 10, "u-juan-1001" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 11, "u-juan-1001" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 12, "u-juan-1001" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 13, "u-juan-1001" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 14, "u-juan-1001" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 15, "u-juan-1001" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 34, "u-laura-1012" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 3, "u-lizeth-60171101" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 4, "u-lizeth-60171101" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 5, "u-lizeth-60171101" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 6, "u-lizeth-60171101" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 7, "u-lizeth-60171101" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 8, "u-lizeth-60171101" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 9, "u-lizeth-60171101" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 10, "u-lizeth-60171101" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 1, "u-lucia-1006" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 2, "u-lucia-1006" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 3, "u-lucia-1006" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 4, "u-lucia-1006" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 5, "u-lucia-1006" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 6, "u-lucia-1006" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 7, "u-lucia-1006" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 8, "u-lucia-1006" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 9, "u-lucia-1006" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 10, "u-lucia-1006" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 28, "u-lucia-1006" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 31, "u-luis-1009" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 1, "u-maria-1002" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 2, "u-maria-1002" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 3, "u-maria-1002" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 4, "u-maria-1002" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 5, "u-maria-1002" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 6, "u-maria-1002" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 7, "u-maria-1002" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 8, "u-maria-1002" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 9, "u-maria-1002" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 10, "u-maria-1002" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 16, "u-maria-1002" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 17, "u-maria-1002" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 18, "u-maria-1002" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 19, "u-maria-1002" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 20, "u-maria-1002" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 36, "u-marta-1014" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 33, "u-miguel-1011" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 39, "u-oscar-1017" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 1, "u-pedro-1005" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 2, "u-pedro-1005" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 3, "u-pedro-1005" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 4, "u-pedro-1005" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 5, "u-pedro-1005" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 6, "u-pedro-1005" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 7, "u-pedro-1005" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 8, "u-pedro-1005" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 9, "u-pedro-1005" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 10, "u-pedro-1005" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 27, "u-pedro-1005" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 35, "u-raul-1013" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 40, "u-silvia-1018" });

            migrationBuilder.DeleteData(
                table: "Agendas",
                keyColumns: new[] { "Id_evento", "Id_usuario" },
                keyValues: new object[] { 32, "u-sofia-1010" });

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 40);

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
                columns: new[] { "Estado", "FechaAsignacion" },
                values: new object[] { "Pendiente", new DateTime(2026, 3, 24, 11, 5, 26, 489, DateTimeKind.Utc).AddTicks(5043) });

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
                columns: new[] { "Estado", "FechaAsignacion" },
                values: new object[] { "Pendiente", new DateTime(2026, 3, 24, 11, 5, 26, 489, DateTimeKind.Utc).AddTicks(5038) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-ana-1004",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "febf1d6a-83c8-45d9-a13c-1cea3eb2f13a", "ana@test.com", new DateTime(2026, 3, 24, 11, 5, 27, 663, DateTimeKind.Utc).AddTicks(9548), "ANA@TEST.COM", "ANA@TEST.COM", "AQAAAAIAAYagAAAAENAmrgek/BN5PjlLlewM1dgRTxec06/BuSOqSrBoFFT+L1KaqarLv6IuhhWYqkjQsQ==", "14643eb0-52c3-4f5a-81e4-4e126dce759c", "ana@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-carlos-1003",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "491a6083-e8ad-4f5e-97ba-1f5715333a2d", "carlos@test.com", new DateTime(2026, 3, 24, 11, 5, 27, 453, DateTimeKind.Utc).AddTicks(2650), "CARLOS@TEST.COM", "CARLOS@TEST.COM", "AQAAAAIAAYagAAAAEBbd2SWJL+a8/5CSmyYR0naI9h6fmylOJUKRNDf3midsUI6P/eW2mP/XHcRUYdMdyw==", "af571ab6-3197-45db-90ec-7b3e91a18e29", "carlos@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-claudia-1016",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "39dd4397-1dc7-4751-99e7-6f0ccf97c89e", "claudia@test.com", new DateTime(2026, 3, 24, 11, 5, 29, 538, DateTimeKind.Utc).AddTicks(3952), "CLAUDIA@TEST.COM", "CLAUDIA@TEST.COM", "AQAAAAIAAYagAAAAEHKpiUtKqsqI7Uq2tyx+kDbrXWTxcBr7tX4hDxMRnOOCx7GwjrB0ZN+Mpeocoj5Upw==", "50422bc9-542d-42fb-acf7-7aa30efb3389", "claudia@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-david-1015",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "61e0a2a1-af4b-4d54-b582-19e2b53282a2", "david@test.com", new DateTime(2026, 3, 24, 11, 5, 29, 420, DateTimeKind.Utc).AddTicks(2683), "DAVID@TEST.COM", "DAVID@TEST.COM", "AQAAAAIAAYagAAAAEPNx+lkBzOEsniNklqdWrhOKBjfJ5Ne1vENNAIeMc84iXrU3h1gZEQA0C0/isGVWqw==", "629f59ee-ca42-4c18-b7d5-f2a681d84fb4", "david@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-eddy-67015593",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6f804301-561f-448d-83e4-ba606dfb1b85", "eddy@test.com", new DateTime(2026, 3, 24, 11, 5, 26, 509, DateTimeKind.Utc).AddTicks(4963), "EDDY@TEST.COM", "EDDY@TEST.COM", "AQAAAAIAAYagAAAAECvcG3A72ek3trb+xWV1KJ+EniIA14r2j7iSs66Pyn35/4zDqp2PVBc91JFDD/Se3A==", "474c501d-c9f9-4f27-9343-0495286c44eb", "eddy@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-elena-1008",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0daf4433-68f8-4333-b76f-53659a640dc3", "elena@test.com", new DateTime(2026, 3, 24, 11, 5, 28, 450, DateTimeKind.Utc).AddTicks(4335), "ELENA@TEST.COM", "ELENA@TEST.COM", "AQAAAAIAAYagAAAAENucWhZnfFnwTG3XwSe9ZOBoF3sk5AgciYQHosPGX5wsbI4M4lXjhMeIHn/83GaSxA==", "e45e68b2-a2ad-415b-9a31-5cd702c6d731", "elena@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-jorge-1007",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "10e3f5a3-942c-4611-849b-b33e995003ce", "jorge@test.com", new DateTime(2026, 3, 24, 11, 5, 28, 274, DateTimeKind.Utc).AddTicks(3162), "JORGE@TEST.COM", "JORGE@TEST.COM", "AQAAAAIAAYagAAAAELhlnHtBNE7oJ4o8DhE2MS7rKJkUe0drXjXhvzfWNS7TMbXLFKrwgi1szwoVenS34g==", "5870c3d4-84c5-4bfe-af27-91c80a436e2c", "jorge@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-juan-1001",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "685d4753-e92c-4573-8b1d-38d328db8179", "juan@test.com", new DateTime(2026, 3, 24, 11, 5, 27, 87, DateTimeKind.Utc).AddTicks(2880), "JUAN@TEST.COM", "JUAN@TEST.COM", "AQAAAAIAAYagAAAAEPi3sz9uie7lMwNgr6vJ0Zoz+zDsD1cuv1hmWnLuanM0zuR4x6qppsnzWCsOMlkUvw==", "18d11623-1f8b-49ce-b697-831ed40f37ea", "juan@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-laura-1012",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a189b715-1174-4dbb-b11d-7b5da8db141f", "laura@test.com", new DateTime(2026, 3, 24, 11, 5, 29, 54, DateTimeKind.Utc).AddTicks(5962), "LAURA@TEST.COM", "LAURA@TEST.COM", "AQAAAAIAAYagAAAAELUQwtj+x7Wul6CSdPAo6A84uuKaPFLQIWy0EAI6VtPB8rLV1Yzywge3X+w+NQjBNg==", "b6cb6c7a-fa0a-4d6d-bd95-8e6ff8a40c02", "laura@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-lizeth-60171101",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "df58e7b6-0849-424d-b700-98da040c130b", "lizeth@test.com", new DateTime(2026, 3, 24, 11, 5, 26, 840, DateTimeKind.Utc).AddTicks(4351), "LIZETH@TEST.COM", "LIZETH@TEST.COM", "AQAAAAIAAYagAAAAELAes86yvvN3GIN51Un29QFaWlxWwqZYK/vd9RTpJccTIFKlgM9bmHu8iPxVupRqVg==", "0eb06871-04a4-470d-bc3f-4b13626074f2", "lizeth@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-lucia-1006",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ff09df98-fae0-40ea-8ff9-de1c9535fe9a", "lucia@test.com", new DateTime(2026, 3, 24, 11, 5, 28, 109, DateTimeKind.Utc).AddTicks(824), "LUCIA@TEST.COM", "LUCIA@TEST.COM", "AQAAAAIAAYagAAAAECTGphNE6G2zqCdxzznfUmL/Fgt7/Ks08OhcfitbgxYqkkvaJlIY7sVY1JfBBwlecQ==", "b6b556cd-608d-4950-b604-e11ec2c252bf", "lucia@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-luis-1009",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d22bdf34-daf9-4b27-8731-80ae4cb9879b", "luis@test.com", new DateTime(2026, 3, 24, 11, 5, 28, 604, DateTimeKind.Utc).AddTicks(8793), "LUIS@TEST.COM", "LUIS@TEST.COM", "AQAAAAIAAYagAAAAEKcLqdGZWnnZtO8uMiw39nT31JDQENBSUgCdn+EUFhP/aX1oYAOkgKBmhNvuE2Tckw==", "9ba2e4fb-e728-4e79-84bf-d0c20a976564", "luis@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-maria-1002",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a62dd9f8-6173-43ff-8afe-54cc3b1fc539", "maria@test.com", new DateTime(2026, 3, 24, 11, 5, 27, 269, DateTimeKind.Utc).AddTicks(8138), "MARIA@TEST.COM", "MARIA@TEST.COM", "AQAAAAIAAYagAAAAEEfnnyTQQ2s/ldA9F/eTxq2Q6gQH0lw1j5PM07tJjL1i3J3qUOpFpG457xkbwRHO8g==", "0d04e3f0-5ddb-4587-b397-4cec033f21c4", "maria@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-marta-1014",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "838b4fde-b844-4c22-ae03-ea81ede486d4", "marta@test.com", new DateTime(2026, 3, 24, 11, 5, 29, 301, DateTimeKind.Utc).AddTicks(7109), "MARTA@TEST.COM", "MARTA@TEST.COM", "AQAAAAIAAYagAAAAEHBoB558J+sxSo0W45zGZCixlcuZElaO3lO7EZMdoP+4gMX5nHJjKOPe25tRbnVCMA==", "6d2024ae-38b2-4036-89be-94945cadf175", "marta@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-miguel-1011",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6e6def22-db9e-4600-840e-b33ee3538b23", "miguel@test.com", new DateTime(2026, 3, 24, 11, 5, 28, 931, DateTimeKind.Utc).AddTicks(3562), "MIGUEL@TEST.COM", "MIGUEL@TEST.COM", "AQAAAAIAAYagAAAAEHPM9NQw46LJzVoQ5cEQPJN+AsFydmm1bIVgvgLh4SwTwNnnLwE1+UERhgBs1fdSjg==", "b21d7246-cd4a-4032-82a4-9bcb442354ae", "miguel@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-oscar-1017",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a88b4080-5736-4d26-8830-7a7aee2cdc45", "oscar@test.com", new DateTime(2026, 3, 24, 11, 5, 29, 656, DateTimeKind.Utc).AddTicks(6872), "OSCAR@TEST.COM", "OSCAR@TEST.COM", "AQAAAAIAAYagAAAAEA0ea1w/1Qxaf/b9FtPEXVU4eh6I2EcPrjLM4M4F08f3B0O26oefKOtqc/yGhPJPtQ==", "f37e95f1-f0db-4bc0-834e-deffb1736c44", "oscar@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-pedro-1005",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "51ad3a41-e670-4db1-9b00-3dfabc2cf3f5", "pedro@test.com", new DateTime(2026, 3, 24, 11, 5, 27, 871, DateTimeKind.Utc).AddTicks(324), "PEDRO@TEST.COM", "PEDRO@TEST.COM", "AQAAAAIAAYagAAAAEOQWJgLvft4o+kQcXTM8EQIcqa91vs7OF+w7YVpq76G3108q2pHxkg0pu03J8RSHtg==", "6a5c16de-5d7b-4050-ab28-915c6aabc379", "pedro@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-raul-1013",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e7790c08-fe8f-42a9-8f9e-04aeb46560d1", "raul@test.com", new DateTime(2026, 3, 24, 11, 5, 29, 187, DateTimeKind.Utc).AddTicks(6486), "RAUL@TEST.COM", "RAUL@TEST.COM", "AQAAAAIAAYagAAAAECS72g6OCDHRP/zesho3SpEmAr3HXmuHjLC6dkid5HyXSUeF3kgFSZPN/yIENWYkwA==", "ee24cf5d-07a5-4327-9b98-3b0654406968", "raul@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-silvia-1018",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4b7cccea-7acf-47ae-a6be-20d017e37b80", "silvia@test.com", new DateTime(2026, 3, 24, 11, 5, 30, 70, DateTimeKind.Utc).AddTicks(4636), "SILVIA@TEST.COM", "SILVIA@TEST.COM", "AQAAAAIAAYagAAAAEIA/yQF2+pqGIDdNArhNQY/0zTbqYLJMG2eqw7I+F6nEgkgVIwVAgnrpAJqZl9r39w==", "39d57c31-e2b8-4b70-99c2-1f6b5aac524b", "silvia@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u-sofia-1010",
                columns: new[] { "ConcurrencyStamp", "Email", "FechaRegistro", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "56cdda5f-84a7-42e9-960a-b799c5df650b", "sofia@test.com", new DateTime(2026, 3, 24, 11, 5, 28, 802, DateTimeKind.Utc).AddTicks(3663), "SOFIA@TEST.COM", "SOFIA@TEST.COM", "AQAAAAIAAYagAAAAEI1/nxsTMj6hMxG5icB0EvxLsRK673h8OxNgiNaMJUorpGFFFTJM5aTtKhXTKdkW3Q==", "03b53215-6447-4d2e-9dab-6128113d35ae", "sofia@test.com" });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 1,
                columns: new[] { "Descripcion", "Hora_finalizacion", "Imagen", "Latitud", "Longitud", "Lugar", "Nombre" },
                values: new object[] { "", new TimeSpan(0, 11, 0, 0, 0), null, 0.0, 0.0, "Oficina Central", "Reunión de Proyecto IATEC" });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 2,
                columns: new[] { "Descripcion", "Hora_finalizacion", "Hora_inicio", "Latitud", "Longitud", "Lugar", "Nombre" },
                values: new object[] { "", new TimeSpan(0, 21, 0, 0, 0), new TimeSpan(0, 19, 0, 0, 0), 0.0, 0.0, "Cancha 5", "Partido de Futbol" });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 3,
                columns: new[] { "Descripcion", "Fecha_finalizacion", "Fecha_inicio", "Hora_finalizacion", "Hora_inicio", "Id_usuario", "Imagen", "Latitud", "Longitud", "Lugar", "Nombre" },
                values: new object[] { "", new DateTime(2026, 3, 25, 0, 0, 0, 0, DateTimeKind.Utc), new DateTime(2026, 3, 25, 0, 0, 0, 0, DateTimeKind.Utc), new TimeSpan(0, 16, 0, 0, 0), new TimeSpan(0, 14, 0, 0, 0), "u-lizeth-60171101", null, 0.0, 0.0, "Auditorio", "Presentación de Tesis" });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id_evento",
                keyValue: 4,
                columns: new[] { "Descripcion", "Hora_finalizacion", "Id_usuario", "Imagen", "Latitud", "Longitud", "Lugar", "Nombre" },
                values: new object[] { "", new TimeSpan(0, 11, 0, 0, 0), "u-lizeth-60171101", null, 0.0, 0.0, "Clínica Dental", "Cita Dental" });
        }
    }
}
