using System.ComponentModel.DataAnnotations;

namespace Jabinja.Dto.Aut;

public class LoginRequestDto
{
    [Required(ErrorMessage = "نام کاربری نمیتواند خالی باشد")]
    [MaxLength(10, ErrorMessage = "نام کاربری نمیتواند بیشتر از 10 کاراکتر باشد")]
    [MinLength(3, ErrorMessage = "نام کاربری نمیتواند کمتر از 3 کاراکتر باشد")]
    public string UserName { get; set; } = null!;


    [Required(ErrorMessage = "کلمه عبور نمیتواند خالی باشد")]
    [MaxLength(20, ErrorMessage = "کلمه عبور نمیتواند بیشتر از 10 کاراکتر باشد")]
    [MinLength(3, ErrorMessage = "کلمه عبور نمیتواند کمتر از 3 کاراکتر باشد")]
    public string Password { get; set; } = null!;
}
