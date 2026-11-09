namespace Jabinja.Entity;

public class User
{
    public int Id { get; set; }
    public string Email { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string Position { get; set; }=null!;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public Employer Employer { get; set; } = null!;

}
