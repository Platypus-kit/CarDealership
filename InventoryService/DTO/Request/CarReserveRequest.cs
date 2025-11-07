using InventoryService.Domain.ValueObjects;

namespace InventoryService.DTO.Request
{
    public record CarReserveRequest(Guid CarId);
}