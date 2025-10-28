using InventoryService.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace InventoryService.Config
{
    public class ZoneTimeConfig : IEntityTypeConfiguration<ZoneTime>
    {
        public void Configure(EntityTypeBuilder<ZoneTime> builder)
        {
            builder.ToTable("ZoneTime");
            builder.HasKey(x => x.Id);
            builder.HasOne(i => i.CarInventory)
                .WithOne(c => c.ZoneTime)
                .HasForeignKey<ZoneTime>(t => t.Id)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
