using System.ComponentModel.DataAnnotations;

namespace Jabinja.Dto.Employer;

public class GetEmployerRequestById
{
    [Range(1, int.MaxValue, ErrorMessage = "شناسه کارفرما معتبر نمی‌باشد")]
    public int Id { get; set; }
}
