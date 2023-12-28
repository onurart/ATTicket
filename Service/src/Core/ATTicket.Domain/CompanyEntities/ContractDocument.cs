namespace ATTicket.Domain.CompanyEntities;
public sealed class ContractDocument : Entity
{
    [ForeignKey("AppUser")]
    public string AppUserId { get; set; }
    public AppUser AppUser { get; set; }
    public string FileName { get; set; }
    public string DocumentData { get; set; }
    public string ContentType { get; set; }

}
