using InventoryService.Domain.ValueObjects;

namespace InventoryService.DTO.Response
{
    public record CarMarkSoldResponse(Indicator Indicator, Position Position, ZoneTime Time);
}
