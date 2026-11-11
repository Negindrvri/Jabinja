using System.ComponentModel.DataAnnotations;

namespace Jabinja.Dto.Employer;

public class CreateEmployerRequestDto
{
    [Required(ErrorMessage = "نام الزمی میباشد")]
    [MaxLength(20, ErrorMessage = "نام نمی تواند بیشتر از 20 کاراکتر باشد")]
    public string FirstName { get; set; } = null!;

    [Required(ErrorMessage = "نام خانوادگی الزمی میباشد")]
    [MaxLength(20, ErrorMessage = "نام خانوادگی نمی تواند بیشتر از 20 کاراکتر باشد")]
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Position { get; set; } = null!;
}
