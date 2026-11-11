using Jabinja.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jabinja.Data.Efconfiguration;

public class _ٍEmployerEFConfiguration
    : IEntityTypeConfiguration<Employer>
{
    public void Configure(EntityTypeBuilder<Employer> builder)
    {
        builder.ToTable("Employer");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(20);


        builder.Property(x => x.LastName)
             .IsRequired()
             .HasMaxLength(20);
    }
}