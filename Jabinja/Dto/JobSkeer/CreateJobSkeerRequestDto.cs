using System.ComponentModel.DataAnnotations;

namespace Jabinja.Dto.JobSkeer;

public class CreateJobSkeerRequestDto
{
    [Required(ErrorMessage = "نام الزمی میباشد")]
    [MaxLength(20, ErrorMessage = "نام نمی تواند بیشتر از 20 کاراکتر باشد")]
    public string FirstName { get; set; } = null!;

    [Required(ErrorMessage = "نام خانوادگی الزمی میباشد")]
    [MaxLength(20, ErrorMessage = "نام خانوادگی نمی تواند بیشتر از 20 کاراکتر باشد")]
    public string LastName { get; set; } = null!;
}
