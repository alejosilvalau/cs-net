using Microsoft.EntityFrameworkCore;
using Silva.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(o => { });
builder.Services.AddDbContext<AlquilerContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
builder.Services.AddScoped<AlquilerRepository>();
builder.Services.AddScoped<AlquilerService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpLogging();
}

app.UseHttpsRedirection();

#region Alquileres

app.MapGet("/alquileres", async (string estado, AlquilerService alquilerService) =>
{
    return await alquilerService.GetByEstadoAsync(estado);
})
.WithName("GetAlquileresByEstado")
.WithOpenApi();

app.MapPost("/alquileres", async (Alquiler alquiler, AlquilerService alquilerService) =>
{
    return await alquilerService.AddAsync(alquiler);
})
.WithName("AddAlquiler")
.WithOpenApi();

app.MapPut("/alquileres/{id}/finalizar", async (int id, AlquilerService alquilerService) =>
{
    return await alquilerService.FinalizarAsync(id);
})
.WithName("FinalizarAlquiler")
.WithOpenApi();

#endregion

app.Run();
