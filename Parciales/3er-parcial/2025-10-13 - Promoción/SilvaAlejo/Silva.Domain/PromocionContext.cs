using Microsoft.EntityFrameworkCore;

namespace Silva.Domain
{
    internal class PromocionContext : DbContext
    {
        internal DbSet<Promocion> Promociones { get; set; }

        internal PromocionContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=dbPromocion;TrustServerCertificate=True;Trusted_Connection=True;");
    }
}
