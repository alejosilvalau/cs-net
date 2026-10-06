using Microsoft.EntityFrameworkCore;

namespace Inmobiliaria.Domain
{
    internal class InmobiliariaContext : DbContext
    {
        internal DbSet<Propiedad> Propiedades { get; set; }

        internal DbSet<TipoPropiedad> TiposPropiedades { get; set; }

        internal InmobiliariaContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS; Database=dbInmobiliaria; Integrated Security=True; trustServerCertificate=true");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Propiedad>(entity =>
            {
                entity.HasIndex(p => p.Titulo).IsUnique();
            });

            modelBuilder.Entity<TipoPropiedad>(entity =>
            {
                entity.HasIndex(p => p.Descripcion).IsUnique();
            });

            modelBuilder.Entity<TipoPropiedad>().HasData(
                new TipoPropiedad { Id = 1, Descripcion = "Casa" },
                new TipoPropiedad { Id = 2, Descripcion = "Departamento" },
                new TipoPropiedad { Id = 3, Descripcion = "PH" }
            );

            modelBuilder.Entity<Propiedad>().HasData(
                new Propiedad { Id = 1, Titulo = "Calle Falsa 123", TipoPropiedadId = 1, Precio = 100000, CantidadHabitaciones = 3, M2 = 100, Descripcion = "Casa acogedora con jardín" },
                new Propiedad { Id = 2, Titulo = "Avenida Siempre Viva 456", TipoPropiedadId = 2, Precio = 150000, CantidadHabitaciones = 5, M2 = 120, Descripcion = "Departamento amplio y luminoso" },
                new Propiedad { Id = 3, Titulo = "Callejón del Gato 789", TipoPropiedadId = 3, Precio = 200000, CantidadHabitaciones = 10, M2 = 300, Descripcion = "PH espacioso con muchas habitaciones" }
            );
        }
    }
}
