namespace Purchase_Service.Domain.Events
{
    public class CarReservationFailedEvent // ошибка при резервирование авто
    {
        public Guid PurchaseId { get; set; }
        public string Reason {  get; set; } = string.Empty;
    }
}