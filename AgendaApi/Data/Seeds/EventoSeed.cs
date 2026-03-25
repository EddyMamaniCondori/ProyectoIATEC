using AgendaApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgendaApi.Data.Seeds;

public class EventoSeed : IEntityTypeConfiguration<Evento>
{
    public void Configure(EntityTypeBuilder<Evento> builder)
    {
        // 🚩 DEFINICIÓN DE VARIABLES DE CONTEXTO (Para evitar CS0103)
        const string imgAniv = "/uploads/aniversario.png";
        const string imgConf = "/uploads/conferencia.jpg";
        const string imgCena = "/uploads/cena_fin_de_mes.jpg";
        const string imgEst = "/uploads/esteban.jpg";
        DateTime fechaBase = new DateTime(2026, 3, 25);

        builder.HasData(
            // ==========================================================================================
            // --- TOP 5 CREADORES (5 Eventos Cada Uno) --- Total 25 Eventos
            // ==========================================================================================

            // 👤 Creador 1: Eddy ("u-eddy-67015593") -> La Paz / El Alto
            new Evento { 
                Id_evento = 1, Id_usuario = "u-eddy-67015593", Nombre = "Lanzamiento Proyecto IATEC", 
                Tipo = "Compartido", Descripcion = "Presentación final de la agenda 3D.", Lugar = "UPEA - El Alto",
                Fecha_inicio = DateTime.SpecifyKind(fechaBase, DateTimeKind.Utc), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase, DateTimeKind.Utc), 
                Hora_inicio = new TimeSpan(9, 0, 0), Hora_finalizacion = new TimeSpan(12, 0, 0),
                Imagen = imgConf, Latitud = -16.4920, Longitud = -68.1921 // El Alto
            },
            new Evento { 
                Id_evento = 2, Id_usuario = "u-eddy-67015593", Nombre = "Reunión Técnica Backend", 
                Tipo = "Exclusivo", Descripcion = "Ajustes de API y base de datos.", Lugar = "San Francisco - La Paz",
                Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(1), DateTimeKind.Utc), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(1), DateTimeKind.Utc), 
                Hora_inicio = new TimeSpan(14, 0, 0), Hora_finalizacion = new TimeSpan(16, 0, 0),
                Imagen = null, Latitud = -16.4955, Longitud = -68.1353 // Centro LP
            },
            new Evento { 
                Id_evento = 3, Id_usuario = "u-eddy-67015593", Nombre = "Cena de Confraternización", 
                Tipo = "Compartido", Descripcion = "Celebración del hito del proyecto.", Lugar = "Calacoto - Zona Sur",
                Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(1), DateTimeKind.Utc), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(1), DateTimeKind.Utc), 
                Hora_inicio = new TimeSpan(20, 0, 0), Hora_finalizacion = new TimeSpan(23, 0, 0),
                Imagen = imgCena, Latitud = -16.5411, Longitud = -68.0805 // Zona Sur LP
            },
            new Evento { 
                Id_evento = 4, Id_usuario = "u-eddy-67015593", Nombre = "Revisión de UI/UX 3D", 
                Tipo = "Exclusivo", Descripcion = "Feedback sobre la interacción de la agenda.", Lugar = "Teleférico Morado",
                Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(2), DateTimeKind.Utc), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(2), DateTimeKind.Utc), 
                Hora_inicio = new TimeSpan(10, 0, 0), Hora_finalizacion = new TimeSpan(11, 30, 0),
                Imagen = imgEst, Latitud = -16.5015, Longitud = -68.1300 // Estación Central
            },
            new Evento { 
                Id_evento = 5, Id_usuario = "u-eddy-67015593", Nombre = "Partido de Futbol", 
                Tipo = "Exclusivo", Descripcion = "Desestres del equipo.", Lugar = "Cancha 5 - El Alto",
                Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(2), DateTimeKind.Utc), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(2), DateTimeKind.Utc), 
                Hora_inicio = new TimeSpan(19, 0, 0), Hora_finalizacion = new TimeSpan(21, 0, 0),
                Imagen = null, Latitud = -16.5100, Longitud = -68.2000 // El Alto
            },

            // 👤 Creador 2: Lizeth Calle ("u-lizeth-60171101") -> La Paz Centro
            new Evento { 
                Id_evento = 6, Id_usuario = "u-lizeth-60171101", Nombre = "Aniversario de la Empresa", 
                Tipo = "Compartido", Descripcion = "Celebración anual.", Lugar = "Multicine LP",
                Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(3), DateTimeKind.Utc), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(3), DateTimeKind.Utc), 
                Hora_inicio = new TimeSpan(11, 0, 0), Hora_finalizacion = new TimeSpan(16, 0, 0),
                Imagen = imgAniv, Latitud = -16.5113, Longitud = -68.1235
            },
            new Evento { 
                Id_evento = 7, Id_usuario = "u-lizeth-60171101", Nombre = "Taller de Liderazgo", 
                Tipo = "Compartido", Descripcion = "Capacitación.", Lugar = "Hotel Presidente",
                Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(4), DateTimeKind.Utc), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(4), DateTimeKind.Utc), 
                Hora_inicio = new TimeSpan(14, 0, 0), Hora_finalizacion = new TimeSpan(18, 0, 0),
                Imagen = imgConf, Latitud = -16.4965, Longitud = -68.1340
            },
            new Evento { 
                Id_evento = 8, Id_usuario = "u-lizeth-60171101", Nombre = "Presentación de Tesis", 
                Tipo = "Compartido", Descripcion = "Defensa de grado.", Lugar = "Auditorio UMSA",
                Fecha_inicio = DateTime.SpecifyKind(fechaBase, DateTimeKind.Utc), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase, DateTimeKind.Utc),
                Hora_inicio = new TimeSpan(14, 0, 0), Hora_finalizacion = new TimeSpan(16, 0, 0), 
                Imagen = null, Latitud = -16.5042, Longitud = -68.1302
            },
            new Evento { 
                Id_evento = 9, Id_usuario = "u-lizeth-60171101", Nombre = "Coaching de Equipo", 
                Tipo = "Exclusivo", Descripcion = "Feedback grupal.", Lugar = "Plaza Abaroa",
                Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(6), DateTimeKind.Utc), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(6), DateTimeKind.Utc), 
                Hora_inicio = new TimeSpan(15, 0, 0), Hora_finalizacion = new TimeSpan(16, 30, 0),
                Imagen = imgEst, Latitud = -16.5110, Longitud = -68.1265
            },
            new Evento { 
                Id_evento = 10, Id_usuario = "u-lizeth-60171101", Nombre = "Cita Dental", 
                Tipo = "Exclusivo", Descripcion = "Limpieza anual.", Lugar = "Clínica Dental Sopocachi",
                Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(2), DateTimeKind.Utc), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(2), DateTimeKind.Utc), 
                Hora_inicio = new TimeSpan(10, 0, 0), Hora_finalizacion = new TimeSpan(11, 0, 0), 
                Imagen = null, Latitud = -16.5080, Longitud = -68.1280
            },

            // 👤 Creador 3: Juan Perez -> Santa Cruz
            new Evento { Id_evento = 11, Id_usuario = "u-juan-1001", Nombre = "Conferencia Tech Latam", Tipo = "Compartido", Descripcion="Evento SCZ", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(10), DateTimeKind.Utc), Hora_inicio = new TimeSpan(9,0,0), Hora_finalizacion = new TimeSpan(17,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(12), DateTimeKind.Utc), Lugar = "Expocruz SCZ", Imagen = imgConf, Latitud = -17.7942, Longitud = -63.1930 },
            new Evento { Id_evento = 12, Id_usuario = "u-juan-1001", Nombre = "Demo de Producto", Tipo = "Exclusivo", Descripcion="Demo SCZ", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(11), DateTimeKind.Utc), Hora_inicio = new TimeSpan(10,0,0), Hora_finalizacion = new TimeSpan(11,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(11), DateTimeKind.Utc), Lugar = "Hotel Los Tajibos", Imagen = null, Latitud = -17.7650, Longitud = -63.1905 },
            new Evento { Id_evento = 13, Id_usuario = "u-juan-1001", Nombre = "Almuerzo Ejecutivo", Tipo = "Compartido", Descripcion="Almuerzo SCZ", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(11), DateTimeKind.Utc), Hora_inicio = new TimeSpan(12,30,0), Hora_finalizacion = new TimeSpan(14,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(11), DateTimeKind.Utc), Lugar = "Punto G", Imagen = imgCena, Latitud = -17.7680, Longitud = -63.1850 },
            new Evento { Id_evento = 14, Id_usuario = "u-juan-1001", Nombre = "Revisión de Contrato", Tipo = "Exclusivo", Descripcion="Legal SCZ", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(13), DateTimeKind.Utc), Hora_inicio = new TimeSpan(15,0,0), Hora_finalizacion = new TimeSpan(16,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(13), DateTimeKind.Utc), Lugar = "Torre Duo", Imagen = null, Latitud = -17.7621, Longitud = -63.1925 },
            new Evento { Id_evento = 15, Id_usuario = "u-juan-1001", Nombre = "Webinar de Seguridad", Tipo = "Compartido", Descripcion="Online SCZ", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(14), DateTimeKind.Utc), Hora_inicio = new TimeSpan(16,0,0), Hora_finalizacion = new TimeSpan(17,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(14), DateTimeKind.Utc), Lugar = "Online", Imagen = imgConf, Latitud = -17.7833, Longitud = -63.1821 },

            // 👤 Creador 4: Maria Gomez -> Cochabamba
            new Evento { Id_evento = 16, Id_usuario = "u-maria-1002", Nombre = "Cena Fin de Mes", Tipo = "Compartido", Descripcion="Cena CBBA", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(5), DateTimeKind.Utc), Hora_inicio = new TimeSpan(19,0,0), Hora_finalizacion = new TimeSpan(21,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(5), DateTimeKind.Utc), Lugar = "La Recoleta", Imagen = imgCena, Latitud = -17.3750, Longitud = -66.1550 },
            new Evento { Id_evento = 17, Id_usuario = "u-maria-1002", Nombre = "Taller de Arte", Tipo = "Compartido", Descripcion="Arte CBBA", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(8), DateTimeKind.Utc), Hora_inicio = new TimeSpan(18,0,0), Hora_finalizacion = new TimeSpan(20,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(8), DateTimeKind.Utc), Lugar = "El Prado", Imagen = imgAniv, Latitud = -17.3891, Longitud = -66.1580 },
            new Evento { Id_evento = 18, Id_usuario = "u-maria-1002", Nombre = "Reunión de Padres", Tipo = "Exclusivo", Descripcion="Colegio CBBA", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(9), DateTimeKind.Utc), Hora_inicio = new TimeSpan(17,0,0), Hora_finalizacion = new TimeSpan(18,30,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(9), DateTimeKind.Utc), Lugar = "Colegio Maryknoll", Imagen = null, Latitud = -17.3680, Longitud = -66.1620 },
            new Evento { Id_evento = 19, Id_usuario = "u-maria-1002", Nombre = "Estudio de Mercado", Tipo = "Exclusivo", Descripcion="MKT CBBA", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(11), DateTimeKind.Utc), Hora_inicio = new TimeSpan(9,0,0), Hora_finalizacion = new TimeSpan(12,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(11), DateTimeKind.Utc), Lugar = "Edificio Los Tiempos", Imagen = imgConf, Latitud = -17.3855, Longitud = -66.1530 },
            new Evento { Id_evento = 20, Id_usuario = "u-maria-1002", Nombre = "Cita con Cliente", Tipo = "Exclusivo", Descripcion="Ventas CBBA", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(12), DateTimeKind.Utc), Hora_inicio = new TimeSpan(11,0,0), Hora_finalizacion = new TimeSpan(12,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(12), DateTimeKind.Utc), Lugar = "Plaza de las Banderas", Imagen = null, Latitud = -17.3810, Longitud = -66.1555 },

            // 👤 Creador 5: Carlos Rodriguez -> Sucre / Potosi
            new Evento { Id_evento = 21, Id_usuario = "u-carlos-1003", Nombre = "Cita Dental Carlos", Tipo = "Exclusivo", Descripcion="Salud Sucre", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(2), DateTimeKind.Utc), Hora_inicio = new TimeSpan(9,0,0), Hora_finalizacion = new TimeSpan(10,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(2), DateTimeKind.Utc), Lugar = "Plaza 25 de Mayo", Imagen = null, Latitud = -19.0475, Longitud = -65.2595 },
            new Evento { Id_evento = 22, Id_usuario = "u-carlos-1003", Nombre = "Partido de Futbol Fin de Semana", Tipo = "Compartido", Descripcion="Deporte Potosi", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(4), DateTimeKind.Utc), Hora_inicio = new TimeSpan(18,0,0), Hora_finalizacion = new TimeSpan(20,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(4), DateTimeKind.Utc), Lugar = "Estadio Victor Agustin Ugarte", Imagen = imgEst, Latitud = -19.5785, Longitud = -65.7518 },
            new Evento { Id_evento = 23, Id_usuario = "u-carlos-1003", Nombre = "Reunión de Socios", Tipo = "Exclusivo", Descripcion="Negocios Sucre", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(6), DateTimeKind.Utc), Hora_inicio = new TimeSpan(10,0,0), Hora_finalizacion = new TimeSpan(12,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(6), DateTimeKind.Utc), Lugar = "Corte Suprema", Imagen = imgConf, Latitud = -19.0425, Longitud = -65.2550 },
            new Evento { Id_evento = 24, Id_usuario = "u-carlos-1003", Nombre = "Cumpleaños Carlos JR", Tipo = "Compartido", Descripcion="Fiesta Sucre", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(7), DateTimeKind.Utc), Hora_inicio = new TimeSpan(15,0,0), Hora_finalizacion = new TimeSpan(20,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(7), DateTimeKind.Utc), Lugar = "Parque Bolivar", Imagen = imgAniv, Latitud = -19.0385, Longitud = -65.2631 },
            new Evento { Id_evento = 25, Id_usuario = "u-carlos-1003", Nombre = "Revisión de Inversiones", Tipo = "Exclusivo", Descripcion="Finanzas", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(9), DateTimeKind.Utc), Hora_inicio = new TimeSpan(16,0,0), Hora_finalizacion = new TimeSpan(17,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(9), DateTimeKind.Utc), Lugar = "Online", Imagen = null, Latitud = -19.0400, Longitud = -65.2600 },

            // ==========================================================================================
            // --- RESTANTES 15 CREADORES (1 Evento Cada Uno) --- (ID 26 al 40)
            // ==========================================================================================

            new Evento { Id_evento = 26, Id_usuario = "u-ana-1004", Nombre = "Clase de Yoga Ana", Tipo = "Compartido", Descripcion="Yoga", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(1), DateTimeKind.Utc), Hora_inicio = new TimeSpan(8,0,0), Hora_finalizacion = new TimeSpan(9,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(1), DateTimeKind.Utc), Lugar = "Gimnasio", Imagen = null, Latitud = -16.5000, Longitud = -68.1200 },
            new Evento { Id_evento = 27, Id_usuario = "u-pedro-1005", Nombre = "Reunión Pedro y Socios", Tipo = "Exclusivo", Descripcion="Socios", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(2), DateTimeKind.Utc), Hora_inicio = new TimeSpan(11,0,0), Hora_finalizacion = new TimeSpan(12,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(2), DateTimeKind.Utc), Lugar = "Oficina Pedro", Imagen = imgEst, Latitud = -17.7800, Longitud = -63.1800 },
            new Evento { Id_evento = 28, Id_usuario = "u-lucia-1006", Nombre = "Exposición de Arte Lucia", Tipo = "Compartido", Descripcion="Arte", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(3), DateTimeKind.Utc), Hora_inicio = new TimeSpan(19,0,0), Hora_finalizacion = new TimeSpan(21,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(3), DateTimeKind.Utc), Lugar = "Galería Moderna", Imagen = imgAniv, Latitud = -16.4900, Longitud = -68.1400 },
            new Evento { Id_evento = 29, Id_usuario = "u-jorge-1007", Nombre = "Reunión Jorge y Proveedores", Tipo = "Exclusivo", Descripcion="Prov", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(4), DateTimeKind.Utc), Hora_inicio = new TimeSpan(10,0,0), Hora_finalizacion = new TimeSpan(12,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(4), DateTimeKind.Utc), Lugar = "Online", Imagen = imgConf, Latitud = -17.3800, Longitud = -66.1600 },
            new Evento { Id_evento = 30, Id_usuario = "u-elena-1008", Nombre = "Cena Cumpleaños Elena", Tipo = "Compartido", Descripcion="B-Day", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(5), DateTimeKind.Utc), Hora_inicio = new TimeSpan(20,0,0), Hora_finalizacion = new TimeSpan(22,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(5), DateTimeKind.Utc), Lugar = "Restaurante Italia", Imagen = imgCena, Latitud = -19.0300, Longitud = -65.2500 },
            new Evento { Id_evento = 31, Id_usuario = "u-luis-1009", Nombre = "Partido Futbol Luis", Tipo = "Compartido", Descripcion="Futbol", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(6), DateTimeKind.Utc), Hora_inicio = new TimeSpan(18,0,0), Hora_finalizacion = new TimeSpan(20,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(6), DateTimeKind.Utc), Lugar = "Cancha 2", Imagen = imgEst, Latitud = -17.7700, Longitud = -63.1700 },
            new Evento { Id_evento = 32, Id_usuario = "u-sofia-1010", Nombre = "Webinar Sofia Innovación", Tipo = "Compartido", Descripcion="Webinar", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(7), DateTimeKind.Utc), Hora_inicio = new TimeSpan(16,0,0), Hora_finalizacion = new TimeSpan(17,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(7), DateTimeKind.Utc), Lugar = "Zoom", Imagen = imgConf, Latitud = -16.5200, Longitud = -68.1100 },
            new Evento { Id_evento = 33, Id_usuario = "u-miguel-1011", Nombre = "Reunión Miguel Marketing", Tipo = "Exclusivo", Descripcion="MKT", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(8), DateTimeKind.Utc), Hora_inicio = new TimeSpan(10,0,0), Hora_finalizacion = new TimeSpan(11,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(8), DateTimeKind.Utc), Lugar = "Oficina Miguel", Imagen = null, Latitud = -17.3900, Longitud = -66.1500 },
            new Evento { Id_evento = 34, Id_usuario = "u-laura-1012", Nombre = "Aniversario Laura y Pedro", Tipo = "Compartido", Descripcion="Love", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(9), DateTimeKind.Utc), Hora_inicio = new TimeSpan(20,0,0), Hora_finalizacion = new TimeSpan(22,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(9), DateTimeKind.Utc), Lugar = "Restaurante Romance", Imagen = imgAniv, Latitud = -17.7900, Longitud = -63.1900 },
            new Evento { Id_evento = 35, Id_usuario = "u-raul-1013", Nombre = "Conferencia Raul Liderazgo", Tipo = "Compartido", Descripcion="Conf", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(10), DateTimeKind.Utc), Hora_inicio = new TimeSpan(9,0,0), Hora_finalizacion = new TimeSpan(17,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(10), DateTimeKind.Utc), Lugar = "Auditorio", Imagen = imgConf, Latitud = -16.5000, Longitud = -68.1300 },
            new Evento { Id_evento = 36, Id_usuario = "u-marta-1014", Nombre = "Reunión Marta Clientes", Tipo = "Exclusivo", Descripcion="CRM", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(11), DateTimeKind.Utc), Hora_inicio = new TimeSpan(11,0,0), Hora_finalizacion = new TimeSpan(12,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(11), DateTimeKind.Utc), Lugar = "Online", Imagen = imgEst, Latitud = -17.7600, Longitud = -63.2000 },
            new Evento { Id_evento = 37, Id_usuario = "u-david-1015", Nombre = "Cena Fin Mes David", Tipo = "Compartido", Descripcion="Cena", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(12), DateTimeKind.Utc), Hora_inicio = new TimeSpan(19,0,0), Hora_finalizacion = new TimeSpan(21,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(12), DateTimeKind.Utc), Lugar = "Pizzería Sony", Imagen = imgCena, Latitud = -17.3700, Longitud = -66.1400 },
            new Evento { Id_evento = 38, Id_usuario = "u-claudia-1016", Nombre = "Reunión Claudia Proveedores", Tipo = "Exclusivo", Descripcion="Prov", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(13), DateTimeKind.Utc), Hora_inicio = new TimeSpan(10,0,0), Hora_finalizacion = new TimeSpan(11,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(13), DateTimeKind.Utc), Lugar = "Oficina Claudia", Imagen = imgConf, Latitud = -16.4800, Longitud = -68.1500 },
            new Evento { Id_evento = 39, Id_usuario = "u-oscar-1017", Nombre = "Partido Futbol Oscar", Tipo = "Compartido", Descripcion="Deporte", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(14), DateTimeKind.Utc), Hora_inicio = new TimeSpan(18,0,0), Hora_finalizacion = new TimeSpan(20,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(14), DateTimeKind.Utc), Lugar = "Cancha 1", Imagen = imgEst, Latitud = -17.7500, Longitud = -63.1600 },
            new Evento { Id_evento = 40, Id_usuario = "u-silvia-1018", Nombre = "Webinar Silvia Ventas", Tipo = "Compartido", Descripcion="Sales", Fecha_inicio = DateTime.SpecifyKind(fechaBase.AddDays(15), DateTimeKind.Utc), Hora_inicio = new TimeSpan(16,0,0), Hora_finalizacion = new TimeSpan(17,0,0), Fecha_finalizacion = DateTime.SpecifyKind(fechaBase.AddDays(15), DateTimeKind.Utc), Lugar = "Zoom", Imagen = imgConf, Latitud = -19.0500, Longitud = -65.2400 }
        );
    }
}