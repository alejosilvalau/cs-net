using Microsoft.Extensions.Configuration;

namespace Silva.UI.Desktop.ApiClients
{
    public static class ApiSettings
    {
        private static readonly IConfiguration _configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        public static string BaseAddress =>
            _configuration.GetValue<string>("Api:BaseAddress")
            ?? throw new InvalidOperationException("Falta Api:BaseAddress en appsettings.json.");
    }
}
