using InventoryService.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryService.Config
{
    public class AdditionalInformationConfig : IEntityTypeConfiguration<AdditionalInformation>
    {
        public void Configure(EntityTypeBuilder<AdditionalInformation> builder)
        {
            builder.ToTable("AdditionalInformation");
            builder.HasKey(x => x.Id);
            builder.HasOne(i => i.CarInventory)
                .WithOne(c => c.AdditionalInformation)
                .HasForeignKey<AdditionalInformation>(t => t.Id)
                .OnDelete(DeleteBehavior.Cascade);

            
        }
    }
}
