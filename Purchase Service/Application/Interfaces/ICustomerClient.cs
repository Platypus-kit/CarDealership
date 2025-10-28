namespace Purchase_Service.Application.Interfaces
{
    public interface ICustomerClient
    {
        Task<bool> ValidateCustomerAsync(Guid customerId);
    }
}