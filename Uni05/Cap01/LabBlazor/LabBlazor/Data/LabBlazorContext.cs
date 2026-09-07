using Microsoft.EntityFrameworkCore;
using LabBlazor.Models;

namespace LabBlazor.Data
{
    public class LabBlazorContext : DbContext
    {
        public LabBlazorContext(DbContextOptions<LabBlazorContext> options) : base(options)
        {
        }

        public DbSet<Alumno> Alumnos { get; set; } = null!;
    }
}
