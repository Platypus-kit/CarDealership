using Purchase_Service.Domain.Enums;

namespace Purchase_Service.Domain.Entities
{
    public class Purchase
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid CustomerId { get; set; }
        public Guid CarId { get; set; }
        public decimal Amount { get; set; }
        public Status Status { get; set; } = Status.Pending; // Pending, Processing, Completed, Failed, Cancelled
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;


    }
}