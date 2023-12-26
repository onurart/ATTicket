namespace ATTicket.Domain.Dtos; 
public sealed class Ticket : Entity
{
    public string? TicketNr { get; set; }
    public Nullable<DateTime> Date_ { get; set; }
    public string? TicketTitle { get; set; }
    public string? AssignedTo { get; set; }
    public string? Asistant { get; set; }
    public int? TicketType { get; set; }
    public int? ServiceType { get; set; }
    public int? TicketState { get; set; }
    public int? Client { get; set; }
    public int? Contract { get; set; }
    public int? Department { get; set; }
    public string? ClientName { get; set; }
    public string? ClientEmail { get; set; }
    public string? ClientPhone { get; set; }
    public int? Product { get; set; }
    public int? Module { get; set; }
    public Nullable<DateTime> CreatedDate { get; set; }
    public Nullable<DateTime> ModifiedDate { get; set; }
    public double? Price { get; set; }
    public double? Kdv { get; set; }
    public double? Total { get; set; }
    public string? TicketTypeExplanation { get; set; }
    public string? Project { get; set; }
    public Nullable<bool> IsPlanned { get; set; }
    public Nullable<bool> MailSended { get; set; }
    public Nullable<bool> SolutionExists { get; set; }
    public Nullable<DateTime> PlannedDate { get; set; }
    public Nullable<DateTime> PlannedStartTime { get; set; }
    public Nullable<DateTime> PlannedEndTime { get; set; }
}