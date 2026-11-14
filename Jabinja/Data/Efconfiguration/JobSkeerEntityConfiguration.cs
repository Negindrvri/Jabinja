using Jabinja.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jabinja.Data.Efconfiguration;

public class JobSkeerEntityConfiguration
     : IEntityTypeConfiguration<JobSeeker>
{
    public void Configure(EntityTypeBuilder<JobSeeker> builder)
    {
        builder.ToTable("JobSkeer");
        

        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(20);


        builder.Property(x => x.BirthDay)
        .IsRequired(false);


        builder.HasMany(x => x.Resumes)
            .WithOne(x => x.JobSeeker)
            .HasForeignKey(x => x.JobSeekerId)
            .IsRequired();
    }
}