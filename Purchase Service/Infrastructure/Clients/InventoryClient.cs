using Purchase_Service.Application.Interfaces;

namespace PurchaseService.Infrastructure.Clients
{
    public class InventoryClient : IInventoryClient
    {
        private readonly HttpClient _httpClient;
        public InventoryClient(HttpClient http)
        {
            _httpClient = http;
        }
        public async Task<bool> ReleaseCarAsync(Guid carId)
        {
            var response = await _httpClient.PostAsJsonAsync("/api/inventory/release", new { carId });
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> ReserveCarAsync(Guid carId, Guid purchaseId)
        {
            var response = await _httpClient.PostAsJsonAsync("/api/inventory/reserve", new { carId, purchaseId });
            return response.IsSuccessStatusCode;
        }
    }
}