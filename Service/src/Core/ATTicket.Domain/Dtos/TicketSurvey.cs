namespace ATTicket.Domain.Dtos; 
public sealed class TicketSurvey
{
    public int SurveyPoint { get; set; }
    public int TicketId { get; set; }
    public string? SurveyNote { get; set; }

}
