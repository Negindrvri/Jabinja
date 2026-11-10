namespace Jabinja.Dto.Company;

public class GetCompanyResponseDto
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Website { get; set; } = null!;
    public string LogoUrl { get; set; } = null!;


}
