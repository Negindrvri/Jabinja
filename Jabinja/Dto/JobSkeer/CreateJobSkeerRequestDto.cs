using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
namespace Jabinja.Dto.JobSkeer;

public class CreateJobSkeerRequestDto
{

    [Required(ErrorMessage = "نام الزمی میباشد")]
    [MaxLength(20, ErrorMessage = "نام نمی تواند بیشتر از 20 کاراکتر باشد")]
    public string FirstName { get; set; } = null!;

    [Required(ErrorMessage = "نام خانوادگی الزمی میباشد")]
    [MaxLength(20, ErrorMessage = "نام خانوادگی نمی تواند بیشتر از 20 کاراکتر باشد")]
    public string LastName { get; set; } = null!;


    [Required(ErrorMessage = "ایمیل الزامی می‌باشد")]
    [EmailAddress(ErrorMessage = "فرمت ایمیل صحیح نیست")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "کلمه عبور الزمی میباشد")]
    public string Password { get; set; } = null!;

    [Required(ErrorMessage = "شماره موبایل عبور الزمی میباشد")]
    [MaxLength(11, ErrorMessage = "شماره موبایل نباید کمتر از 11 رقم باشد و با 09 شروع شود")]
    public string PhoneNumber { get; set; } = null!;
}
