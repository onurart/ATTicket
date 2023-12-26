namespace ATTicket.Domain.Dtos; 
public sealed class InComingMailSettings : Entity
{
    public string HostName { get; set; }
    public int Port { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string EmailAddressTo { get; set; }
    public string ExcluedEmailAddressFrom { get; set; }
    public string IncluedEmailAddressFrom { get; set; }
}
