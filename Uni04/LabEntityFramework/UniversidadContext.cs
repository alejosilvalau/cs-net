using Microsoft.EntityFrameworkCore;

namespace LabEntityFramework;

public class UniversidadContext : DbContext
{
    public DbSet<Alumno> Alumnos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=LabEntityFramework;TrustServerCertificate=True;Trusted_Connection=True;");
        //optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
    }

    public UniversidadContext()
    {
        this.Database.EnsureCreated();
    }
}
