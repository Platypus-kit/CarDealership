namespace CatalogService.Entityes
{
    public class Order
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid OrderId { get; set; } = Guid.NewGuid();
        public bool IsCompleted { get; set; }
    }
}