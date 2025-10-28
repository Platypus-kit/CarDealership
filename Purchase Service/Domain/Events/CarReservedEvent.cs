namespace Purchase_Service.Domain.Events
{
    public class CarReservedEvent // авто зарезервирован
    {
        public Guid PurchaseId { get; set; } 
        public Guid CarId { get; set; }
        public DateTime ReservedAt { get; set; }
    }
}
