namespace ATTicket.Domain.CompanyEntities;
public class SubFirm : Entity
{
    public int ContractId { get; set; }
    public int ClientId { get; set; }
    public int UserAmount { get; set; }
    public string Explanation { get; set; }
}