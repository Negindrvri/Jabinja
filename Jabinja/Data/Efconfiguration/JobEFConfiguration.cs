using Jabinja.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jabinja.Data.Efconfiguration;

public class JobEFConfiguration
     : IEntityTypeConfiguration<Job>
{
    public void Configure(EntityTypeBuilder<Job> builder)

    {
        builder.ToTable("Job");


        builder.Property(x=>x.Title)
            .IsRequired() 
            .HasMaxLength(50);


        builder.Property(x => x.Description)
            .IsRequired();
            

        builder.Property(x => x.Salary)
            .IsRequired();

        builder.Property(x => x.ExpireAt)
            .IsRequired(false);

        builder.HasOne(x => x.Company)
           .WithMany()
           .HasForeignKey(x => x.CompanyId)
           .IsRequired();


        builder.HasOne(x => x.JobCategory)
           .WithMany()
           .HasForeignKey(x => x.JobCategoryId)
           .IsRequired();



    }
}