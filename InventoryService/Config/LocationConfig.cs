using InventoryService.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace InventoryService.Config
{
    public class LocationConfig : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.ToTable("Location");
            builder.HasKey(x => x.Id);
            builder.HasOne(i => i.CarInventory)
                .WithOne(c => c.Location)
                .HasForeignKey<Location>(t => t.Id)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
