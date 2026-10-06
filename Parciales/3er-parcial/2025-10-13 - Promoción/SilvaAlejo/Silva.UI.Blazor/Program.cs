using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Silva.UI.Blazor;
using Silva.UI.Blazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Esta URL se podría pasar a un setting
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7284/") });
builder.Services.AddScoped<PromocionApiClient>();

await builder.Build().RunAsync();
