using InventoryService.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace InventoryService.Config
{
    public class PositionConfig : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.ToTable("Position");
            builder.HasKey(x => x.Id);
            builder.HasOne(i => i.CarInventory)
                .WithOne(c => c.Position)
                .HasForeignKey<Position>(t => t.Id)
                .OnDelete(DeleteBehavior.Cascade);


        }
    }
}
