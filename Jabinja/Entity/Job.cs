namespace Jabinja.Entity;

public class Job:BaseEntity
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public long Salary { get; set; }
    public string Requirements { get; set; } = null!;
    public DateTime? ExpireAt { get; set; }

    public int CompanyId { get; set; }
    public Company Company { get; set; } = null!;

    public int JobCategoryId { get; set; }
    public JobCategory JobCategory { get; set; } = null!;
}
