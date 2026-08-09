using LabAPIRest.Models;
using Microsoft.EntityFrameworkCore;

namespace LabAPIRest.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Alumno> Alumnos { get; set; }
    }
}
