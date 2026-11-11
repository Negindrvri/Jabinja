namespace Jabinja.Entity;

public class User:BaseEntity
{
    public string Email { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string Position { get; set; }=null!;
    public Employer? Employer { get; set; } 
    public JobSeeker? JobSeeker { get; set; }
    public List<Resume> Resumes  { get; set; } = new();

}
