using Purchase_Service.Domain.Entities;

namespace Purchase_Service.Application.Interfaces
{
    public interface IPaymentClient
    {
        Task<PaymentResult> ProcessPaymentAsync(Guid orderId, decimal amount, Guid customerId);
        Task<bool> RefundPaymentAsync(Guid transactionId);
    }
}