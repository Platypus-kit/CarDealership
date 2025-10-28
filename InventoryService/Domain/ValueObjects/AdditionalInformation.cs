using InventoryService.Domain.Entities;

namespace InventoryService.Domain.ValueObjects
{
    public class AdditionalInformation
    {
        public Guid Id { get; set; }
        public Guid CarInventoryId { get; set; }
        public CarInventory CarInventory { get; set; } = null!;
        public int CurrentMileage { get; set; }
        public string? ConditionNotes { get; set; }
        public DateTime? InspectionDate { get; set; }
    }
}