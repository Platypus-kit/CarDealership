using InventoryService.Domain.ValueObjects;

namespace InventoryService.Domain.Entities
{
    public class CarInventory
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public AdditionalInformation AdditionalInformation { get; set; } = null!;
        public Indicator Indicator { get; set; } = null!;
        public Location Location { get; set; } = null!;
        public Position Position { get; set; } = null!;
        public ZoneTime ZoneTime { get; set; } = null!;

    }
}
