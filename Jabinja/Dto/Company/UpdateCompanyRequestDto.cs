using System.ComponentModel.DataAnnotations;

namespace Jabinja.Dto.Company;

public class UpdateCompanyRequestDto
{
    [Required(ErrorMessage = "نام شرکت الزامی می‌باشد")]
    [MaxLength(100, ErrorMessage = "نام شرکت نمی‌تواند بیشتر از 100 کاراکتر باشد")]
    public string Name { get; set; } = null!;

    [MaxLength(1000, ErrorMessage = "توضیحات نمی‌تواند بیشتر از 1000 کاراکتر باشد")]
    public string? Description { get; set; }

    [Url(ErrorMessage = "آدرس وب‌سایت معتبر نیست")]
    public string? Website { get; set; }
}
