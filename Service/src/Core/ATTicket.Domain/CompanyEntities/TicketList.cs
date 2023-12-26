namespace ATTicket.Domain.CompanyEntities;
public class TicketList : Entity
{
    public TicketList(){}
    public TicketList(string id,string appUserId):base(id){AppUserId = appUserId;}
    public int ClientId { get; set; }
    public int CreatedType { get; set; }
    public string? TicketNr { get; set; }
    public string? TicketTitle { get; set; }
    [ForeignKey("AppUser")]
    public string AppUserId { get; set; }
    public AppUser AppUser { get; set; }
    public string? TicketState { get; set; }
    public string? ClientName { get; set; }
    public string? ProductName { get; set; }
    public long Duration { get; set; }
    public string? TicketType { get; set; }
}

