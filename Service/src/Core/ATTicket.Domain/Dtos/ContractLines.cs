namespace ATTicket.Domain.Dtos; 
public sealed class ContractLine : Entity
{
    public string AppUserId { get; set; }
    public int LineNr { get; set; }
    public string? InvoiceNr { get; set; }
    public double? Amount { get; set; }
    public string? LineExplanation { get; set; }
}
