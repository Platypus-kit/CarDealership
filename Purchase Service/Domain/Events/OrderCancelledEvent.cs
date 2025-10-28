namespace Purchase_Service.Domain.Events
{
    public class OrderCancelledEvent // заказ отменен
    {
        public Guid PurchaseId { get; set; }
        public string Reason { get; set; } = string.Empty;
        public DateTime CancelledAt { get; set; }
    }
}