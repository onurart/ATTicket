namespace ATTicket.Domain.Dtos; 
public sealed class ContractDocumentDto : Entity
{
    public string AppUserId { get; set; }
    public string FileName { get; set; }
    public byte[] DocumentData { get; set; }
    public string ContentType { get; set; }

}
