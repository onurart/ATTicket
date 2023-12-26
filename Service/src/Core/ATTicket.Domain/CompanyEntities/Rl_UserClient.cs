namespace ATTicket.Domain.CompanyEntities;
public sealed class Rl_UserClient : Entity
{
    [ForeignKey("AppUser")]
    public string AppUserId { get; set; }
    public AppUser AppUser { get; set; }
    public int Priority { get; set; }
}

