namespace ATTicket.Domain.AppEntities.Identity;
public sealed class AppRole : IdentityRole<string>
{
    public AppRole(){}
    public AppRole(string title, string code, string name)
    {
        Id = Guid.NewGuid().ToString();
        Code = code;
        Title = title;
        Name = name;
        NormalizedName = name.ToUpper();
    }
    public string Code { get; set; }
    public string Title { get; set; }
}
