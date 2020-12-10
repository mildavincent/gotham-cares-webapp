using GothamCares.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GothamCares.DataServices.EntityConfigurations
{
    //defines the table constraints.
    public class FoodPacketEntityTypeConfiguration : IEntityTypeConfiguration<FoodPacket>
    {
        public void Configure(EntityTypeBuilder<FoodPacket> builder)
        {
            builder.HasKey(p => p.Id);
        }
    }
}
