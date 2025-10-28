namespace Purchase_Service.Domain.Events
{
    public class CustomerValidatedEvent // клиент прошел проверку
    {
        public Guid PurchaseId { get; set; }
        public Guid UserId { get; set; }
        public bool IsApproved { get; set; } = false;
    }
}