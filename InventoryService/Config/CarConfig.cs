using InventoryService.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using InventoryService.Domain.Entities;

namespace InventoryService.Config
{
    public class CarConfig: IEntityTypeConfiguration<Car>
    {

        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Car");
            builder.HasKey(x => x.Id);
            builder.HasOne(i => i.CarInventory)
                .WithOne(c => c.Car)
                .HasForeignKey<Car>(t => t.Id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}