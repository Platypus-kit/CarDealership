using InventoryService.Domain.Entities;
using InventoryService.Domain.ValueObjects;

namespace InventoryService.DTO.Response
{
    public record AvailableResponse(List<CarInventory> Cars);
}