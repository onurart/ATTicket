namespace ATTicket.Domain.CompanyEntities;
public sealed class TicketMail : Entity
{
    [ForeignKey("Ticket")]
    public int TicketId { get; set; }
    public Tickets Ticket { get; set; }
    public string? MailSubject { get; set; }
    public string? EMail { get; set; }
    public string? EMailTo { get; set; }
    public string? EMail_CC { get; set; }
    public string? EMail_BCC { get; set; }
    public string? EMail_Message { get; set; }
}
