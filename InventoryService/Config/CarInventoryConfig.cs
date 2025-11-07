using InventoryService.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using InventoryService.Domain.Entities;

namespace InventoryService.Config
{
    public class CarInventoryConfig : IEntityTypeConfiguration<CarInventory>
    {
        public void Configure(EntityTypeBuilder<CarInventory> builder)
        {
            builder.ToTable("CarInventory");
            builder.HasKey(x => x.Id);
            builder.HasOne(i => i.AdditionalInformation)
                 .WithOne(c => c.CarInventory)
                 .HasForeignKey<AdditionalInformation>(t => t.CarInventoryId)
                 .OnDelete(DeleteBehavior.Cascade);

            
            builder.HasKey(x => x.Id);
            builder.HasOne(i => i.Indicator)
                .WithOne(c => c.CarInventory)
                .HasForeignKey<Indicator>(t => t.CarInventoryId)
                .OnDelete(DeleteBehavior.Cascade);
            
            
            builder.HasKey(x => x.Id);
            builder.HasOne(i => i.Location)
                .WithOne(c => c.CarInventory)
                .HasForeignKey<Location>(t => t.CarInventoryId)
                .OnDelete(DeleteBehavior.Cascade);

            
            builder.HasKey(x => x.Id);
            builder.HasOne(i => i.Position)
                .WithOne(c => c.CarInventory)
                .HasForeignKey<Position>(t => t.CarInventoryId)
                .OnDelete(DeleteBehavior.Cascade);

            
            builder.HasKey(x => x.Id);
            builder.HasOne(i => i.ZoneTime)
                .WithOne(c => c.CarInventory)
                .HasForeignKey<ZoneTime>(t => t.CarInventoryId)
                .OnDelete(DeleteBehavior.Cascade);

           
            builder.HasKey(x => x.Id);
            builder.HasOne(i => i.Car)
                .WithOne(c => c.CarInventory)
                .HasForeignKey<Car>(t => t.Id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
