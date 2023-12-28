namespace ATTicket.Domain.Dtos; 
public sealed class TicketSurveyDto
{
    public int SurveyPoint { get; set; }
    public int TicketId { get; set; }
    public string? SurveyNote { get; set; }

}
