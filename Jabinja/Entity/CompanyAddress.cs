namespace Jabinja.Entity;

public class CompanyAddress:BaseEntity
{
    public string City { get; set; } = null!;
    public string Street { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public int CompanyId { get; set; }
    public Company Company { get; set; } = null!;
}
