using Microsoft.EntityFrameworkCore;
using Purchase_Service.Domain.Entities;

namespace CatalogService.Data
{
    public class OrderDbContext : DbContext 
    {
        public DbSet<Purchase> Purchases { get; set; }
        public OrderDbContext(DbContextOptions<OrderDbContext> options): base(options) 
        {
            
        }
    }
}
