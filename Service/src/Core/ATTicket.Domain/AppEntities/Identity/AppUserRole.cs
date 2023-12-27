namespace ATTicket.Domain.AppEntities.Identity;
public sealed class AppUserRole : Entity
{
    public AppUserRole()
    {

    }
    public AppUserRole(string id, string roleid, string userid) : base(id)
    {
        RoleId = roleid;
        UserId = userid;
    }
    [ForeignKey("AppRole")]
    public string RoleId { get; set; }
    public AppRole AppRole { get; set; }
    [ForeignKey("User")]
    public string UserId { get; set; }
    public AppUser? User { get; set; }
}
