namespace ATTicket.Domain.CompanyEntities;
public sealed class TicketSurvey
{
    public int SurveyPoint { get; set; }
    [ForeignKey("Ticket")]
    public int TicketId { get; set; }
    public Ticket Ticket { get; set; }
    public string? SurveyNote { get; set; }

}
