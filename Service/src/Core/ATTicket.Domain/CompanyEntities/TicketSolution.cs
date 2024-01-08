namespace ATTicket.Domain.CompanyEntities;
public sealed class TicketSolution : Entity
{
    [ForeignKey("Ticket")]
    public string TicketId { get; set; }
    public Tickets Ticket { get; set; }
    public string? Solution { get; set; }
    public string? TicketDefinition { get; set; }
    public string? TicketLabels { get; set; }
}
