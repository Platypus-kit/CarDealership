using CatalogService.Data;
using Microsoft.EntityFrameworkCore;
using Purchase_Service.Application.Interfaces;
using Purchase_Service.Domain.Entities;

namespace Purchase_Service.Infrastructure.Orders
{
    public class IPurchase : IPurchaseRepository
    {
        private readonly OrderDbContext _context;

        public IPurchase(OrderDbContext context)
        {
            _context = context;
        }
        public Task AddAsync(Purchase purchase)
        {
           return _context.Purchases.Add(purchase);
        }

        public Task DeleteAsync(Guid id)
        {
            var purchase = _context.Purchases.FindAsync(id);
            if (purchase != null)
                _context.Purchases.Remove(purchase);
        }

        public Task<List<Purchase>> GetByCustomerAsync(Guid id)
        {
            return _context.Purchases.Add(purchase);
        }

        public Task<Purchase?> GetByIdAsync(Guid id)
        {
            return _context.Purchases.FirstOrDefaultAsync(p => p.Id == id);
        }

        public Task<List<Purchase>> GetPendingOrdersAsync()
        {
            return _context.Purchases.Add(purchase);
        }

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public Task UpdateAsync(Purchase purchase)
        {
            return _context.Purchases.Update(purchase);
        }
    }
}
