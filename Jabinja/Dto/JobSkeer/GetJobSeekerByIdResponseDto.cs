namespace Jabinja.Dto.JobSkeer;

public class GetJobSeekerByIdResponseDto
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Position { get; set; } = null!;

    public DateTime? BirthDay { get; set; }

    
}