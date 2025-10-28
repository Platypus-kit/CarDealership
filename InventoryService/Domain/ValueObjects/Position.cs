using InventoryService.Domain.Entities;
using InventoryService.Domain.Enums;

namespace InventoryService.Domain.ValueObjects
{
    public class Position
    {
        public Guid Id { get; set; }
        public Guid CarInventoryId { get; set; }
        public CarInventory CarInventory { get; set; } = null!;
        public InventoryStatus Status { get; set; } = InventoryStatus.Pending;
        public Guid? ReservedForOrder { get; set; }
        public DateTime ReservedUntil { get; set; } = DateTime.UtcNow;
    }
}
