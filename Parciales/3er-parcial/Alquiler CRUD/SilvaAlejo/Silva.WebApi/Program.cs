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

app.MapGet("/alquileres", async (AlquilerService alquilerService) =>
{
    return await alquilerService.GetAllAsync();
})
.WithName("GetAlquileres")
.WithOpenApi();

app.MapGet("/alquileres/{id}", async (int id, AlquilerService alquilerService) =>
{
    return await alquilerService.GetByIdAsync(id);
})
.WithName("GetAlquilerById")
.WithOpenApi();

app.MapPost("/alquileres", async (Alquiler alquiler, AlquilerService alquilerService) =>
{
    return await alquilerService.AddAsync(alquiler);
})
.WithName("AddAlquiler")
.WithOpenApi();

app.MapPut("/alquileres/{id}", async (int id, Alquiler alquiler, AlquilerService alquilerService) =>
{
    return await alquilerService.UpdateAsync(id, alquiler);
})
.WithName("UpdateAlquiler")
.WithOpenApi();

app.MapDelete("/alquileres/{id}", async (int id, AlquilerService alquilerService) =>
{
    await alquilerService.DeleteAsync(id);
    return Results.NoContent();
})
.WithName("DeleteAlquiler")
.WithOpenApi();

#endregion

app.Run();
