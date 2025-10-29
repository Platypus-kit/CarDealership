using InventoryService.Config;
using InventoryService.Domain.Entities;
using InventoryService.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace InventoryService.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<CarInventory> CarInventories { get; set; }
        public DbSet<AdditionalInformation> AdditionalInformation { get; set; }
        public DbSet<Indicator> Indicator { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<ZoneTime> ZoneTime { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdditionalInformationConfig());
            modelBuilder.ApplyConfiguration(new IndicatorConfig());
            modelBuilder.ApplyConfiguration(new LocationConfig());
            modelBuilder.ApplyConfiguration(new PositionConfig());
            modelBuilder.ApplyConfiguration(new ZoneTimeConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
