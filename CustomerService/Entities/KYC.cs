namespace CustomerService.Entities
{
    public class KYC
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string Provider { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }
    }
}
