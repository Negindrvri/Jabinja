namespace Jabinja.Entity;

public class JobSeeker : User
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateTime? BirthDay { get; set; }
    public Resume? Resume { get; set; }

}
