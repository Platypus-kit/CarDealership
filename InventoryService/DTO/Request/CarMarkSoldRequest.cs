using InventoryService.Domain.Enums;
using InventoryService.Domain.ValueObjects;

namespace InventoryService.DTO.Request
{
    public record CarMarkSoldRequest(Guid CarId);
}