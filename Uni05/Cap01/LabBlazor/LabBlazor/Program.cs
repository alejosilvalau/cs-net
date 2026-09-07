using Microsoft.EntityFrameworkCore;
using LabBlazor.Components;
using LabBlazor.Data;
using LabBlazor.Models;

namespace LabBlazor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<LabBlazorContext>(options =>
                options.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=LabBlazor;TrustServerCertificate=True;Trusted_Connection=True;"));

            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<LabBlazorContext>();
                db.Database.EnsureCreated();

                if (!db.Alumnos.Any())
                {
                    db.Alumnos.AddRange(
                        new Alumno { Nombre = "Lucas", Apellido = "Garcia", Legajo = "53291", Direccion = "Av. Mitre 1234" },
                        new Alumno { Nombre = "Camila", Apellido = "Lopez", Legajo = "54102", Direccion = "Belgrano 567" },
                        new Alumno { Nombre = "Mateo", Apellido = "Rodriguez", Legajo = "55038", Direccion = "San Martin 890" },
                        new Alumno { Nombre = "Sofia", Apellido = "Martinez", Legajo = "52847", Direccion = "Rivadavia 3210" },
                        new Alumno { Nombre = "Benjamin", Apellido = "Fernandez", Legajo = "56714", Direccion = "Hipolito Yrigoyen 456" }
                    );
                    db.SaveChanges();
                }
            }

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
