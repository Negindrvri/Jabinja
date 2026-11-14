namespace Jabinja.Entity;

public class Resume:BaseEntity
{
    public int JobSeekerId { get; set; }

    public JobSeeker JobSeeker { get; set; } = null!;

    public string JobName { get; set; } = null!;

    public string? Gender { get; set; }

    public string? City { get; set; }

    public string? Street { get; set; }

    public int? PostalCode { get; set; }


}
