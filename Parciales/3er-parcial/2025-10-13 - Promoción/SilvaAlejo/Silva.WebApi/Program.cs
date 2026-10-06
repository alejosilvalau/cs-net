using Silva.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(o => { });

// Blazor WebAssembly corre en otro origen: habilitar CORS para la UI.
builder.Services.AddCors(options =>
{
    options.AddPolicy("Blazor", policy =>
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpLogging();
}

app.UseHttpsRedirection();
app.UseCors("Blazor");

#region Promociones

app.MapGet("/promociones", async (string estado) =>
{
    PromocionService promocionService = new PromocionService();

    return await promocionService.GetByEstadoAsync(estado);
})
.WithName("GetPromocionesByEstado")
.WithOpenApi();

app.MapPost("/promociones", async (Promocion promocion) =>
{
    PromocionService promocionService = new PromocionService();

    return await promocionService.AddAsync(promocion);
})
.WithName("AddPromocion")
.WithOpenApi();

app.MapPut("/promociones/{id}/expirar", async (int id) =>
{
    PromocionService promocionService = new PromocionService();

    return await promocionService.ExpirarAsync(id);
})
.WithName("ExpirarPromocion")
.WithOpenApi();

#endregion

app.Run();
