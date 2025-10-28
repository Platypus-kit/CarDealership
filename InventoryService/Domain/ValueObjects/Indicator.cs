using InventoryService.Domain.Entities;

namespace InventoryService.Domain.ValueObjects
{
    public class Indicator
    {
        public Guid Id { get; set; }
        public Guid Carid { get; set; }
        public Guid CarInventoryId { get; set; }
        public CarInventory CarInventory { get; set; } = null!;
        public string VIN { get; set; }
    }
}
