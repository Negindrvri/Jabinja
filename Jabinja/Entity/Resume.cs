namespace Jabinja.Entity;

public class Resume:BaseEntity
{
    public int UserId { get; set; }
    public User User { get; set; } = null!;
    public int JobSkeerId {  get; set; }
    public string JobName { get; set; } = null!;
    public string? Gender {  get; set; }
    public string? City { get; set; } 
    public string? Street { get; set; } 
    public int? PostalCode { get; set; }
    public JobSeeker JobSeeker { get; set; } = null!;
    public int JobSeekerId { get; set; }

}
