using Purchase_Service.Application.Interfaces;


namespace PurchaseService.Infrastructure.Clients
{
    public class CustomerClient : ICustomerClient
    {
        private readonly HttpClient _httpClient;
        public CustomerClient(HttpClient http)
        {
            _httpClient = http;
        }
        public async Task<bool> ValidateCustomerAsync(Guid customerId)
        {
            var response = await _httpClient.GetAsync($"/api/customers/{customerId}/validate");
            return response.IsSuccessStatusCode;
        }
    }
}