namespace ATTicket.Domain.Dtos; 
public  sealed  class SubFirmDto : Entity
{
    public int ContractId { get; set; }
    public string AppUserId { get; set; }
    public int UserAmount { get; set; }
    public string Explanation { get; set; }
}