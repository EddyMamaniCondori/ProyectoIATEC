using AgendaApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaApi.Data.Seeds;

public class UsuarioSeed : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        var hasher = new PasswordHasher<Usuario>();

        // IDs fijos para que las llaves foráneas en Eventos no fallen
        string eddyId = "u-eddy-67015593";
        string lizethId = "u-lizeth-60171101";

        builder.HasData(
            new Usuario {
                Id = eddyId,
                UserName = "eddy@test.com",
                NormalizedUserName = "EDDY@TEST.COM",
                Email = "eddy@test.com",
                NormalizedEmail = "EDDY@TEST.COM",
                Nombre = "Eddy",
                Ape_paterno = "Mamani",
                Ape_materno = "Condori",
                PhoneNumber = "67015593", // <-- Atributo de Identity
                Fecha_naci = DateTime.SpecifyKind(new DateTime(1995, 5, 20), DateTimeKind.Utc),
                Foto_perfil = "/images/user-default.png",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null!, "Password123!")
            },
            new Usuario {
                Id = lizethId,
                UserName = "lizeth@test.com",
                NormalizedUserName = "LIZETH@TEST.COM",
                Email = "lizeth@test.com",
                NormalizedEmail = "LIZETH@TEST.COM",
                Nombre = "Lizeth Aidee",
                Ape_paterno = "Calle",
                Ape_materno = "Fernandez",
                PhoneNumber = "60171101", // <-- Atributo de Identity
                Fecha_naci = DateTime.SpecifyKind(new DateTime(1998, 8, 15), DateTimeKind.Utc),
                Foto_perfil = "/images/user-default.png",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null!, "Password123!")
            }
        );
    }
}