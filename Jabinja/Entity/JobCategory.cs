namespace Jabinja.Entity;

public class JobCategory:BaseEntity
{
    public string Name { get; set; } = null!;
    public string Slug { get; set; } = null!;
    public int? ParentId { get; set; }
   
}
