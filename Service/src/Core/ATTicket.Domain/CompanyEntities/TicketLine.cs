namespace ATTicket.Domain.CompanyEntities;
public sealed class TicketLine : Entity
{
    [ForeignKey("Ticket")]

    public int TicketId { get; set; }
    public Ticket Ticket { get; set; }
    public string? AssignedTo { get; set; }
    public string? Assistant { get; set; }
    public Nullable<DateTime> StartTime { get; set; }
    public Nullable<DateTime> EndTime { get; set; }
    public int? LineType { get; set; }
    public int? LineState { get; set; }
    public string? LineMessage { get; set; }
    public string? Note { get; set; }
    public long? Duration { get; set; }
    public bool Closed { get; set; }
    public string? CreatedUser { get; set; }
    public Nullable<DateTime> CreatedTime { get; set; }
}