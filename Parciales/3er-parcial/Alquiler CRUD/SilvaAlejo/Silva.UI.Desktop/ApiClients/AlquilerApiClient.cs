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

        public static async Task<IEnumerable<AlquilerDto>> GetAllAsync()
        {
            IEnumerable<AlquilerDto>? entities = null;
            HttpResponseMessage response = await client.GetAsync("alquileres");

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

        public static async Task<AlquilerDto?> GetByIdAsync(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"alquileres/{id}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<AlquilerDto>();
            }
            response.EnsureSuccessStatusCode();
            return null;
        }

        public static async Task AddAsync(AlquilerDto alquilerDto)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("alquileres", alquilerDto);
            response.EnsureSuccessStatusCode();
        }

        public static async Task UpdateAsync(int id, AlquilerDto alquilerDto)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync($"alquileres/{id}", alquilerDto);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync($"alquileres/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
