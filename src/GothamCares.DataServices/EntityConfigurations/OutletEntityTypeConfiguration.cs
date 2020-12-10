using GothamCares.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GothamCares.DataServices.EntityConfigurations
{
    //defines the table constraints.
    public class OutletEntityTypeConfiguration : IEntityTypeConfiguration<Outlet>
    {
        public void Configure(EntityTypeBuilder<Outlet> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o=>o.Id).UseIdentityAlwaysColumn();  
            builder.Property(o => o.Name).IsRequired().HasMaxLength(100);
            builder.Property(o => o.StreetName).IsRequired().HasMaxLength(300);
            builder.Property(o => o.Landmark).HasMaxLength(300);
            builder.Property(o => o.OpeningDate).IsRequired(); 
           //builder.Property(o => o.ReqVolunteers).IsRequired();       
        }
    }
}
