namespace ATTicket.Domain.Dtos; 
public sealed class TicketListDto : Entity
{
    public int ClientId { get; set; }
    public int CreatedType { get; set; }
    public string? TicketNr { get; set; }
    public string? TicketTitle { get; set; }
    public string AppUserId { get; set; }
    public string? TicketState { get; set; }
    public string? ClientName { get; set; }
    public string? ProductName { get; set; }
    public long Duration { get; set; }
    public string? TicketType { get; set; }
}

