using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Silva.UI.Desktop.ApiClients
{
    public class PromocionApiClient
    {
        private static HttpClient client = new HttpClient();
        static PromocionApiClient()
        {
            // Esta URL se podría pasar a un setting
            client.BaseAddress = new Uri("https://localhost:7284/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<IEnumerable<PromocionDto>> GetByEstadoAsync(string estado)
        {
            IEnumerable<PromocionDto>? entities = null;
            HttpResponseMessage response = await client.GetAsync("promociones?estado=" + Uri.EscapeDataString(estado));

            if (response.IsSuccessStatusCode)
            {
                entities = await response.Content.ReadAsAsync<IEnumerable<PromocionDto>>();
            }
            else
            {
                response.EnsureSuccessStatusCode();
            }
            return entities ?? Enumerable.Empty<PromocionDto>();
        }

        public static async Task AddAsync(PromocionDto promocionDto)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("promociones", promocionDto);
            response.EnsureSuccessStatusCode();
        }

        public static async Task ExpirarAsync(int id)
        {
            HttpResponseMessage response = await client.PutAsync($"promociones/{id}/expirar", null);
            response.EnsureSuccessStatusCode();
        }
    }
}
