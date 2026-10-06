using System.Net.Http.Json;
using Silva.UI.Blazor.Models;

namespace Silva.UI.Blazor.Services
{
    public class PromocionApiClient
    {
        private readonly HttpClient _http;

        public PromocionApiClient(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<PromocionDto>> GetByEstadoAsync(string estado)
        {
            return await _http.GetFromJsonAsync<List<PromocionDto>>(
                "promociones?estado=" + Uri.EscapeDataString(estado))
                ?? new List<PromocionDto>();
        }

        public async Task AddAsync(PromocionDto promocionDto)
        {
            HttpResponseMessage response = await _http.PostAsJsonAsync("promociones", promocionDto);
            response.EnsureSuccessStatusCode();
        }

        public async Task ExpirarAsync(int id)
        {
            HttpResponseMessage response = await _http.PutAsync($"promociones/{id}/expirar", null);
            response.EnsureSuccessStatusCode();
        }
    }
}
