using InventoryService.Domain.Entities;

namespace InventoryService.Domain.ValueObjects
{
    public class Location
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid CarInventoryId { get; set; }
        public CarInventory CarInventory { get; set; } = null!;
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
    }
}