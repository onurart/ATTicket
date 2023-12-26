namespace ATTicket.Domain.CompanyEntities;
public class ContractProduct : Entity
{
    public int ContractId { get; set; }
    public int ProductId { get; set; }
    public int ProductUserAmount { get; set; }
    public int FirmAmount { get; set; }
    public string Explanation { get; set; }
    public string LicenceKey { get; set; }
}
