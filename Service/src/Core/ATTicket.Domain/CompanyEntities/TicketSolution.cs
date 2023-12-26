namespace ATTicket.Domain.CompanyEntities;
public class TicketSolution : Entity
{
    public int TicketId { get; set; }
    public string? Solution { get; set; }
    public string? TicketDefinition { get; set; }
    public string? TicketLabels { get; set; }
}
