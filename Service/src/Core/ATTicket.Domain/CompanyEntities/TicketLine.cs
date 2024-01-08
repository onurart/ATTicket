namespace ATTicket.Domain.CompanyEntities;
public sealed class TicketLine : Entity
{
    [ForeignKey("Ticket")]

    public int TicketId { get; set; }
    public Tickets Ticket { get; set; }
    public string? AssignedTo { get; set; }
    public string? Assistant { get; set; }
    public int? LineType { get; set; }
    public int? LineState { get; set; }
    public string? LineMessage { get; set; }
    public string? Note { get; set; }
    public long? Duration { get; set; }
    public bool Closed { get; set; }
}