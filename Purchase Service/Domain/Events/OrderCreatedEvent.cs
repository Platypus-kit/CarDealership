namespace Purchase_Service.Domain.Events
{
    public class OrderCreatedEvent // заказ создан
    {
        public Guid PurchaseId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid CarId { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}