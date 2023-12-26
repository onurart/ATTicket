namespace ATTicket.Domain.Dtos; 
public sealed class OutGoingMailSettings : Entity
{
    public string HostName { get; set; }
    public int Port { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }


}

