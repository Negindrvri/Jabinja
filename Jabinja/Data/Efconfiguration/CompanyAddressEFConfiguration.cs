using Jabinja.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jabinja.Data.Efconfiguration;

public class CompanyAddressEFConfiguration
    : IEntityTypeConfiguration<CompanyAddress>
{
    public void Configure(EntityTypeBuilder<CompanyAddress> builder)
    {
        builder.ToTable("CompanyAddress");

      

        builder.Property(x => x.City)
            .IsRequired()
            .HasMaxLength(20);



        builder.Property(x=>x.Street)
            .IsRequired()
            .HasMaxLength (50);

        builder.Property(x => x.PostalCode)
                  .IsRequired()
                  .HasMaxLength(20);


        //builder.HasOne(x => x.Company)
        //           .WithMany(x => x.Addresses)
        //           .HasForeignKey(x => x.CompanyId)
        //           .IsRequired();


        builder.HasOne(x => x.Company)
    .WithMany(x => x.Addresses)
    .HasForeignKey(x => x.CompanyId)
    .OnDelete(DeleteBehavior.NoAction)
    .IsRequired();
    }
}