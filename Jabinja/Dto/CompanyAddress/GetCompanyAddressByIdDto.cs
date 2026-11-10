namespace Jabinja.Dto.CompanyAddress;

public class GetCompanyAddressByIdDto
{
    public int CompanyId { get; set; }
    public string City { get; set; } = null!;
    public string Street { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
}
