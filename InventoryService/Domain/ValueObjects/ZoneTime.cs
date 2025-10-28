using InventoryService.Domain.Entities;

namespace InventoryService.Domain.ValueObjects
{
    public class ZoneTime
    {
        public Guid Id { get; set; }
        public Guid CarInventoryId { get; set; }
        public CarInventory CarInventory { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime LastStatusChange { get; set; }
    }
}
