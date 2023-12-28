namespace ATTicket.Domain.Dtos; 
public sealed class ContractProductDto : Entity
{
    public string AppUserId { get; set; }
    public DateTime OrderDate { get; set; }
    public int ProductId { get; set; }
    public int ProductUserAmount { get; set; }
    public int FirmAmount { get; set; }
    public string Explanation { get; set; }
    public string LicenceKey { get; set; }
}
