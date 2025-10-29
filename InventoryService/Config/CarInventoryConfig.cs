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
                 .HasForeignKey<AdditionalInformation>(t => t.Id)
                 .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Indicator");
            builder.HasKey(x => x.Id);
            builder.HasOne(i => i.Indicator)
                .WithOne(c => c.CarInventory)
                .HasForeignKey<Indicator>(t => t.Id)
                .OnDelete(DeleteBehavior.Cascade);
            
            builder.ToTable("Location");
            builder.HasKey(x => x.Id);
            builder.HasOne(i => i.Location)
                .WithOne(c => c.CarInventory)
                .HasForeignKey<Location>(t => t.Id)
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Position");
            builder.HasKey(x => x.Id);
            builder.HasOne(i => i.Position)
                .WithOne(c => c.CarInventory)
                .HasForeignKey<Position>(t => t.Id)
                .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("ZoneTime");
            builder.HasKey(x => x.Id);
            builder.HasOne(i => i.ZoneTime)
                .WithOne(c => c.CarInventory)
                .HasForeignKey<ZoneTime>(t => t.Id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
