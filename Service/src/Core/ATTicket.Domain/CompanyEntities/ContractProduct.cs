namespace ATTicket.Domain.CompanyEntities;
public sealed class ContractProduct : Entity
{
    [ForeignKey("AppUser")]
    public string AppUserId { get; set; }
    public AppUser AppUser { get; set; }
    public DateTime OrderDate { get; set; }
    [ForeignKey("Product")]
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public int ProductUserAmount { get; set; }
    public int FirmAmount { get; set; }
    public string Explanation { get; set; }
}
