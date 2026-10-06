using Microsoft.EntityFrameworkCore;

namespace Silva.Domain
{
    public class AlquilerContext : DbContext
    {
        public DbSet<Alquiler> Alquileres { get; set; }

        public AlquilerContext(DbContextOptions<AlquilerContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
    }
}
