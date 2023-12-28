namespace ATTicket.Domain.Dtos; 
public  sealed  class TicketStatuDto : Entity
{
    public string? MainStatu { get; set; }
    public string? Statu { get; set; }
    public bool Active { get; set; }
}
