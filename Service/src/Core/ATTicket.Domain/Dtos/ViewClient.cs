namespace ATTicket.Domain.Dtos;
public sealed class ViewClient : Entity
{
    public string? Code { get; set; }
    public string? Title { get; set; }
    public string? FullName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? EMail { get; set; }
    public string? Representative { get; set; }
    public string? RepresentativePhone { get; set; }
    public string? RepresentativeEmail { get; set; }


}

