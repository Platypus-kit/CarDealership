using InventoryService.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace InventoryService.Config
{
    public class IndicatorConfig : IEntityTypeConfiguration<Indicator>
    {
        public void Configure(EntityTypeBuilder<Indicator> builder)
        {
            builder.ToTable("Indicator");
            builder.HasKey(x => x.Id);
            builder.HasOne(i => i.CarInventory)
                .WithOne(c => c.Indicator)
                .HasForeignKey<Indicator>(t => t.Id)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
