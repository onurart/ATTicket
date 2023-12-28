namespace ATTicket.Domain.Dtos;
public sealed class ViewContractDto : Entity
{
    public string AppUserId { get; set; }
    public string? ContractNo { get; set; }
    public string? ClientTitle { get; set; }
    public string? Definition { get; set; }
    public DateTime BegDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Active { get; set; }
    public string? Explanation { get; set; }
}
