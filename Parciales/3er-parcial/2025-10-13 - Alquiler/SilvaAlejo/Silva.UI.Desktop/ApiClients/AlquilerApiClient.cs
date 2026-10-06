using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Silva.UI.Desktop.ApiClients
{
    public class AlquilerApiClient
    {
        private static HttpClient client = new HttpClient();
        static AlquilerApiClient()
        {
            client.BaseAddress = new Uri(ApiSettings.BaseAddress);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<IEnumerable<AlquilerDto>> GetByEstadoAsync(string estado)
        {
            IEnumerable<AlquilerDto>? entities = null;
            HttpResponseMessage response = await client.GetAsync("alquileres?estado=" + Uri.EscapeDataString(estado));

            if (response.IsSuccessStatusCode)
            {
                entities = await response.Content.ReadAsAsync<IEnumerable<AlquilerDto>>();
            }
            else
            {
                response.EnsureSuccessStatusCode();
            }
            return entities ?? Enumerable.Empty<AlquilerDto>();
        }

        public static async Task AddAsync(AlquilerDto alquilerDto)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("alquileres", alquilerDto);
            response.EnsureSuccessStatusCode();
        }

        public static async Task FinalizarAsync(int id)
        {
            HttpResponseMessage response = await client.PutAsync($"alquileres/{id}/finalizar", null);
            response.EnsureSuccessStatusCode();
        }
    }
}
