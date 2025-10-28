using CatalogService.Entityes;
using Microsoft.EntityFrameworkCore;

namespace CatalogService.Data
{
    public class AppDbContext : DbContext 
    {
        public DbSet<Order> Orders { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) 
        {
        
        }


    }
}
