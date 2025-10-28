using Purchase_Service.Domain.Entities;

namespace Purchase_Service.Application.Interfaces
{
    public interface IPurchaseRepository
    {
        //получить заказ по ID
        Task<Purchase?> GetByIdAsync(Guid id);
        //получить заказы клиента
        Task<List<Purchase>> GetByCustomerAsync(Guid id);
        //добавить новый заказ
        Task AddAsync(Purchase purchase);
        //обновить существующий заказ
        Task UpdateAsync(Purchase purchase);
        //удалить заказ
        Task DeleteAsync(Guid id);
        //получить ожидающие заказы
        Task<List<Purchase>> GetPendingOrdersAsync();
        //сохранить изменения
        Task<int> SaveChangesAsync();  
    }
}