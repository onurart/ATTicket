namespace ATTicket.Domain.CompanyEntities;
public sealed class TicketSurvey:Entity
{
    public int SurveyPoint { get; set; }
    [ForeignKey("Ticket")]
    public string TicketId { get; set; }
    public Tickets Ticket { get; set; }
    public string? SurveyNote { get; set; }

}
