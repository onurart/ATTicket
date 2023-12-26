namespace ATTicket.Domain.Dtos; 
public sealed class TicketPdfDetail : Entity
{
    public string TicketNr { get; set; }
    public string PersonelName { get; set; }
    public int TicketType { get; set; }
    public string ContractNo { get; set; }
    public string ClientTitle { get; set; }
    public string ClientName { get; set; }
    public DateTime Startime { get; set; }
    public DateTime Endtime { get; set; }
    public string Definition_ { get; set; }
    public string WorkDefinition { get; set; }
    public string Note { get; set; }
    public double Price { get; set; }
    public double VatAmount { get; set; }
    public double Total { get; set; }
    public double Kdv { get; set; }

}
