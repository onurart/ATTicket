namespace ATTicket.Domain.CompanyEntities;
public class Department : Entity
{
    public string? DepartmentName { get; set; }
    [ForeignKey("AppUser")]
    public string AppUserId { get; set; }
    public AppUser AppUser { get; set; }
    public string? Incharge { get; set; }
    public string? Color { get; set; }
}

