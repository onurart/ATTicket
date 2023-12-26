namespace ATTicket.Domain.Dtos; 
public sealed class ContractOrder : Entity
{
    public string OrderNo { get; set; }
    public string Docode { get; set; }
    public string ClientCode { get; set; }
    public string CLientDef { get; set; }
    public string AppUserId { get; set; }
    public DateTime OrderDate { get; set; }
    public double OrderTotal { get; set; }
    public double TotalVat { get; set; }
    public double GrossTotal { get; set; }
    public double LineNet { get; set; }
    public string? InvoiceNo { get; set; }
    public string Currency { get; set; }
}
