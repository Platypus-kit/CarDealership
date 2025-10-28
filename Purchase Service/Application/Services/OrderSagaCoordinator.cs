using Purchase_Service.Application.Interfaces;
using Purchase_Service.Domain.Enums;
namespace Purchase_Service.Application.Services
{
    public class OrderSagaCoordinator
    {
        private readonly ICustomerClient _customerClient;
        private readonly IInventoryClient _inventoryClient;
        private readonly IPaymentClient _paymentClient;
        private readonly IPurchaseRepository _purchaseRepository;
        private readonly ILogger<OrderSagaCoordinator> _logger;
        
        public OrderSagaCoordinator(ICustomerClient customerClient, IInventoryClient inventoryClient,
            IPaymentClient paymentClient, ILogger<OrderSagaCoordinator> logger, IPurchaseRepository purchaseRepository)
        {
            _customerClient = customerClient;
            _inventoryClient = inventoryClient;
            _paymentClient = paymentClient;
            _logger = logger;
            _purchaseRepository = purchaseRepository;
        }

        public async Task ProcessOrderAsync(Guid orderId)
        {
            var purchase = await _purchaseRepository.GetByIdAsync(orderId);
            if (purchase == null) throw new ArgumentNullException("purchase is null");
            try
            {
                purchase.Status = Status.Processing;
                await _purchaseRepository.UpdateAsync(purchase);
                purchase.Status = Status.Completed;
                await _purchaseRepository.UpdateAsync(purchase);
            }
            catch (Exception ex) 
            {
                purchase.Status = Status.Failed;
                await _purchaseRepository.UpdateAsync(purchase);
            }
        }

        // вызвать и реализовать в этом классе методы ReserveCarAsync, ValidateCustomerAsync, ProcessPaymentAsync и катчи к ним, реализовать класс который наследуется от IPurchaseRepository в infrastructure создать папку Purchase и в нем сделать реализацию IPurchase

        // 2. Установить статус "Processing"
        // 3. Выполнить последовательно шаги SAGA:
        //    - Резервирование автомобиля
        //    - Проверка клиента  
        //    - Обработка платежа
        // 4. При успехе - установить статус "Completed"
        // 5. При ошибке - запустить компенсацию
        public async Task ReserveCarAsync(Guid orderId, Guid carId)
        {
            var purchase = await _purchaseRepository.GetByIdAsync(orderId);
            if (purchase == null) throw new ArgumentNullException("purchase is null");
            try
            {
                purchase.CarId = carId;
                await _purchaseRepository.UpdateAsync(purchase);

            }
            catch (Exception ex)
            {
                purchase.Status = Status.Failed;
                await _purchaseRepository.UpdateAsync(purchase);
            }
        }

        public async Task ValidateCustomerAsync(Guid orderId, Guid customer)
        {
            var purchase = await _purchaseRepository.GetByIdAsync(orderId);
            if (purchase == null) throw new ArgumentNullException("purchase is null");
            try
            {
                purchase.CustomerId = customer;
                await _purchaseRepository.UpdateAsync(purchase);
            }
            catch (Exception ex)
            {
                purchase.Status = Status.Failed;
                await _purchaseRepository.UpdateAsync(purchase);
            }
        }

        public async Task ProcessPaymentAsync(Guid orderId, decimal amount)
        {
            var purchase = await _purchaseRepository.GetByIdAsync(orderId);
            if (purchase == null) throw new ArgumentNullException("purchase is null");
            try
            {
                purchase.Amount = amount;
                await _purchaseRepository.UpdateAsync(purchase);
            }
            catch (Exception ex)
            {
                purchase.Status = Status.Failed;
                await _purchaseRepository.UpdateAsync(purchase);
            }
        }
    }
}