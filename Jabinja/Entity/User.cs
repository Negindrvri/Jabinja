namespace Jabinja.Entity;

public class User:BaseEntity
{
    public string Email { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public JobSeeker? JobSeeker { get; set; }
  

}
