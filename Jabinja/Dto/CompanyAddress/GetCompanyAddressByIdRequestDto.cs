namespace Jabinja.Dto.CompanyAddress;

public class GetCompanyAddressByIdRequestDto
{
    public string City { get; set; } = null!;
    public string Street { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
}
