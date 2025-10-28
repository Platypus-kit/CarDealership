using Purchase_Service.Domain.Enums;

namespace Purchase_Service.Domain.Entities
{
    public class PaymentResult
    {
        // успешность операции
        public bool Success { get; set; }
        // идентификатор транзакции
        public Guid? TransactionId { get; set; }
        // сообщение об ошибке
        public string? Error { get; set; }
        // статус платежа
        public Status Status { get; set; }
        // время обработки
        public DateTime ProcessedAt { get; set; }
        // сумма платежа
        public decimal Amount { get; set; }
        // валюта (например, "USD", "RUB")
        public string Currency { get; set; }

    }
}
