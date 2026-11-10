namespace Jabinja.Entity;

public class CompanyAddress:BaseEntity
{
    public string? City { get; set; } 
    public string? Street { get; set; }
    public string PostalCode { get; set; } = null!;
    public Company Company { get; set; } = null!;
}
