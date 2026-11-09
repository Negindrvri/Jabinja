namespace Jabinja.Entity;

public class Job:BaseEntity
{
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public long Salary { get; set; }
    public string Location { get; set; } = null!;
    public string Requirements { get; set; } = null!;
    public DateTime? ExpireAt { get; set; }

    public long CompanyId { get; set; }
    public Company Company { get; set; } = null!;
}
