namespace ATTicket.Domain.CompanyEntities;
public sealed class Ticket : Entity
{
    public string? TicketNr { get; set; }
    public string? TicketTitle { get; set; }
    public string? AssignedTo { get; set; }
    public string? Asistant { get; set; }
    public int? TicketType { get; set; }
    public int? ServiceType { get; set; }
    public string? TicketState { get; set; }
    [ForeignKey("AppUser")]
    public string AppUserId { get; set; }
    public AppUser AppUser { get; set; }
    public int? Contract { get; set; }


    [ForeignKey("Departments")]
    public string DepartmentId { get; set; }
    public Departments Departments { get; set; }
    public int? Department { get; set; }
    public string? ClientEmail { get; set; }
    public string? ClientPhone { get; set; }
    [ForeignKey("Product")]
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public int? Module { get; set; }
    public double? Price { get; set; }
    public double? Kdv { get; set; }
    public double? Total { get; set; }
    public string? TicketTypeExplanation { get; set; }
}