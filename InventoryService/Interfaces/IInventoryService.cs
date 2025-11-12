using InventoryService.Domain.Entities;
using InventoryService.DTO.Request;
using InventoryService.DTO.Response;
using System.Net;

namespace InventoryService.Interfaces
{
    public interface IInventoryService 
    {
        //- POST /api/inventory/reserve - резервирование автомобиля
        //- POST /api/inventory/release - освобождение резервирования
        //- POST /api/inventory/mark-sold - отметка о продаже
        //- GET /api/inventory/available - список доступных автомобилей
        //- GET /api/inventory/{carId} - информация по конкретному автомобилю

        Task<CarReserveResponse> ReserveAsync(CarReserveRequest carReserveRequest); 
        Task<List<CarReleaseResponse>> ReleaseAsync(CarReleaseRequest carReleaseRequest);
        Task<CarMarkSoldResponse?> MarkSoldAsync(CarMarkSoldRequest carMarkSoldRequest);
        Task<AvailableResponse?> AvailableAsync();
        Task<CarInformationResponse?> InformationAsync(CarInformationRequest carInformationRequest);
    }
}
