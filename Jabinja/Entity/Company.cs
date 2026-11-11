namespace Jabinja.Entity;

public class Company : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Website { get; set; } = null!;
    public string LogoUrl { get; set; } = null!;
    public List<CompanyAddress> Addresses { get; set; } = new List<CompanyAddress>();
}
