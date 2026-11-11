using Jabinja.Entity;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Jabinja.Data;

public class ApplicationDbContext:DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
    {

    }



    
    public DbSet<JobSeeker> JobSeekers { get; set; }
    public DbSet<Company> Company { get; set; }
    public DbSet<CompanyAddress> CompanyAddresses { get; set; }
    public DbSet<Employer> employers { get; set; }
    public DbSet<User> users { get; set; }
    public DbSet<Job> Jobs{ get; set; }
    public DbSet<JobCategory> JobCategories { get; set; }
    public DbSet<Resume> Resumes { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(ApplicationDbContext).Assembly
        );
    }



}
