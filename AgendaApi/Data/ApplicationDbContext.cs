using AgendaApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace AgendaApi.Data;

public class ApplicationDbContext : IdentityDbContext<Usuario>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)
    {
    }
    // 1. Registramos la tabla de Eventos
    public DbSet<Evento> Eventos { get; set; }
    public DbSet<Agenda> Agendas { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.ConfigureWarnings(w => 
            w.Ignore(RelationalEventId.PendingModelChangesWarning));
    }

    // 2. Configuramos las relaciones y reglas de la base de datos
    protected override void OnModelCreating(ModelBuilder builder)
    {
        // Esto es obligatorio para que Identity (Login) siga funcionando
        base.OnModelCreating(builder);

        // Configuración de la relación 1:N (Un Usuario -> Muchos Eventos)
        builder.Entity<Evento>()
            .HasOne(e => e.Creador)      // Un evento tiene un creador
            .WithMany(u => u.MisEventos) // Un usuario tiene muchos eventos
            .HasForeignKey(e => e.Id_usuario) // La llave foránea es Id_usuario
            .OnDelete(DeleteBehavior.Cascade); // Si borras al usuario, se borran sus eventos
        builder.Entity<Evento>().ToTable("Eventos");
        //**************************************
        //          N:M (AGENDA)
        //*******************************************

        builder.Entity<Agenda>(entity =>
        {
            entity.ToTable("Agendas");

            // Definir Clave Primaria Compuesta
            entity.HasKey(a => new { a.Id_usuario, a.Id_evento });

            // Relación Agenda -> Usuario (FORZANDO LA FK)
            entity.HasOne(a => a.Usuario)
                .WithMany(u => u.MisSuscripciones)
                .HasForeignKey(a => a.Id_usuario) // <--- Esto evita que cree "UsuarioId"
                .IsRequired();

            // Relación Agenda -> Evento
            entity.HasOne(a => a.Evento)
                .WithMany() 
                .HasForeignKey(a => a.Id_evento)
                .IsRequired();
        });
        //**************************************
        //         SEEDERS
        //  *******************************************
        builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

    }
    
    
}