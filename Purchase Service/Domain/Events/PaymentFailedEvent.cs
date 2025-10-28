namespace Purchase_Service.Domain.Events
{
    public class PaymentFailedEvent // платеж не прошел :(
    {
        public Guid PurchaseId { get; set; }
        public string Reason { get; set; } = string.Empty;
    }
}
