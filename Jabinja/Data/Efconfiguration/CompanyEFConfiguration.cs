using Jabinja.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jabinja.Data.Efconfiguration;

public class CompanyEFConfiguration
    : IEntityTypeConfiguration<Company>
{
    public void Configure(EntityTypeBuilder<Company> builder)
    {
        builder.ToTable("Company");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(50)
            ;
        builder.Property(x => x.Website)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(x => x.Description)
            .IsRequired()
            .HasMaxLength(200)
            ;

        builder.Property(x => x.LogoUrl)
            .IsRequired()
            .HasMaxLength(500)
            ;

        builder.HasMany(x => x.Addresses)
            .WithOne()
            .IsRequired();


    }
}