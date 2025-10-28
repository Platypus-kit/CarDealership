namespace CatalogService.Entityes
{
    public class Car
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }

        
    }
}
