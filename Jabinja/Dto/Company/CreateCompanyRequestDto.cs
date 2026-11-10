using System.ComponentModel.DataAnnotations;

namespace Jabinja.Dto.Company;

public class CreateCompanyRequestDto
{
    [Required(ErrorMessage = "نام شرکت الزامی میباشد")]
    [MaxLength(100, ErrorMessage = "نام بیشتر از 50 کاراکتر باشد")]
    public string Name { get; set; } = null!;

    [Required(ErrorMessage = "شرح وظایف الزامی میباشد")]
    [MaxLength(200, ErrorMessage = "شرح وظایف نمیتواند بیشتر از 200 کاراکتر باشد")]
    public string Description { get; set; } = null!;

    [Required(ErrorMessage = "وب سایت الزامی میباشد")]
    [MaxLength(20, ErrorMessage = "نام وب سایت نمیتواند بیشتر از 20 کاراکتر باشد")]
    public string Website { get; set; } = null!;

    public IFormFile? Logo { get; set; }


}
