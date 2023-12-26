namespace ATTicket.Domain.CompanyEntities;
public class User : Entity
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public int Department { get; set; }
    public int ClientId { get; set; }
    public bool ExcludeTicket { get; set; }

}
