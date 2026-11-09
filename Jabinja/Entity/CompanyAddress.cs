namespace Jabinja.Entity;

public class CompanyAddress:BaseEntity
{
    public int CompanyId { get; set; }
    public string City { get; set; } = null!;
    public string Street { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public Company Company { get; set; } = null!;
}
