namespace Purchase_Service.Domain.Events
{
    public class PaymentSucceededEvent // платеж успешен :)
    {
        public Guid PurchaseId { get; set; }
        public Guid PaymentId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaidAt { get; set; }
    }
}