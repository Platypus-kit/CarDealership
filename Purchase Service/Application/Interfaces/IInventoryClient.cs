namespace Purchase_Service.Application.Interfaces
{
    public interface IInventoryClient
    {
        Task<bool> ReserveCarAsync(Guid carId, Guid purchaseId);
        Task<bool> ReleaseCarAsync(Guid carId);
    }
}
