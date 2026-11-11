using System.ComponentModel.DataAnnotations;

namespace Jabinja.Dto.CompanyAddress;

public class CreateCompanyAddressRequestDto
{
    [Required(ErrorMessage = "نام شهر نمیتواند خالی باشد")]
    [MaxLength(20, ErrorMessage = "نام شهر نمیتواند بیشتر از 20 کاراکتر باشد")]
    public string City { get; set; } = null!;

    [Required(ErrorMessage = "نام خیابان نمیتواند خالی باشد")]
    [MaxLength(50, ErrorMessage = "نام خیابان نمیتواند بیشتر از 50 کاراکتر باشد")]
    public string Street { get; set; } = null!;

    [Required(ErrorMessage = "کدپستی نمیتواند خالی باشد")]
    [MaxLength(20, ErrorMessage = "کدپستی نمیتواند بیشتر از 20 کاراکتر باشد")]
    public string PostalCode { get; set; } = null!;

}
