namespace InventoryService.Domain.Entities
{
    public class Car
    {
        public Guid Id { get; set; }
        public Guid CarInventoryId { get; set; }
        public CarInventory CarInventory { get; set; } = null!;
        public string? Model { get; set; }
        public string? Brand { get; set; }
        public int? Year { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
    }
}
