namespace ATTicket.Domain.CompanyEntities;
public sealed class ContractLine : Entity
{
    public int ContractId { get; set; }
    public int LineNr { get; set; }
    public string? InvoiceNr { get; set; }
    public double? Amount { get; set; }
    public string? LineExplanation { get; set; }
}
