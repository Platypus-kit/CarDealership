using CustomerService.Entities;
using Microsoft.EntityFrameworkCore;

namespace CatalogService.Data
{
    public class AppDbContext : DbContext 
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<KYC> KYCs { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) 
        {
        
        }
    }
}
