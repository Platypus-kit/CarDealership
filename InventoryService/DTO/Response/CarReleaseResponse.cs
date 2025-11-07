using InventoryService.Domain.ValueObjects;

namespace InventoryService.DTO.Response
{
    public record CarReleaseResponse(Indicator Indicator, Position Position, ZoneTime Time);
}
