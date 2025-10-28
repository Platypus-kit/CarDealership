namespace Purchase_Service.Domain.DTO
{
    public class PaymentRequest
    {
        public Guid OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string PaymentMethod { get; set; }
        public string Description { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
    }
}