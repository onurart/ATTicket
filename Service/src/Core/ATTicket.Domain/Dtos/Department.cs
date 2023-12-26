namespace ATTicket.Domain.Dtos; 
public sealed class Department : Entity
{
    public string? DepartmentName { get; set; }
    public string AppUserId { get; set; }
    public string? Incharge { get; set; }
    public string? Color { get; set; }
}

