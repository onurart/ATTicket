namespace ATTicket.Domain.CompanyEntities;
public sealed class ViewContract : Entity
{
    [ForeignKey("AppUser")]
    public string AppUserId { get; set; }
    public AppUser AppUser { get; set; }
    public string? ContractNo { get; set; }
    public string? ClientTitle { get; set; }
    public string? Definition { get; set; }
    public DateTime BegDate { get; set; }
    public DateTime EndDate { get; set; }
    public string? Explanation { get; set; }
}
