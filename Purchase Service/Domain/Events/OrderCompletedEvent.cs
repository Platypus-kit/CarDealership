namespace Purchase_Service.Domain.Events
{
    public class OrderCompletedEvent // заказа завершен 
    {
        public Guid PurchaseId { get; set; }
        public DateTime ComplitedAt { get; set; }
    }
}