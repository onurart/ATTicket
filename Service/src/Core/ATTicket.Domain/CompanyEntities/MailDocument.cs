namespace ATTicket.Domain.CompanyEntities;
public class MailDocument : Entity
{
    public int MailId { get; set; }
    public byte[] UploadedFile { get; set; } = new byte[] { };
    public string UploadedFileName { get; set; } = string.Empty;
    public string UploadedFileContentType { get; set; } = string.Empty;
}
