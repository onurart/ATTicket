namespace ATTicket.Domain.CompanyEntities;
public sealed class OutGoingMailSettingses : Entity
{
    public string HostName { get; set; }
    public int Port { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}