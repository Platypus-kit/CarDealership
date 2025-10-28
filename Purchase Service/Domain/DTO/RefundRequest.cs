namespace Purchase_Service.Domain.DTO
{
    public class RefundRequest
    {
        // идентификатор оригинальной транзакции
        public Guid TransactionId { get; set; }
        // идентификатор заказа
        public Guid OrderId { get; set; }
        // сумма возврата (может быть частичной)
        public decimal Amount { get; set; }
        // причина возврата
        public string Reason { get; set; } 
    }
}