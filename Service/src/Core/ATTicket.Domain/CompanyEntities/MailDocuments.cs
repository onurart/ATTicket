namespace ATTicket.Domain.CompanyEntities;
public sealed  class MailDocuments : Entity
{
    public int MailId { get; set; }
    public string UploadedFile { get; set; }
    public string UploadedFileName { get; set; } = string.Empty;
    public string UploadedFileContentType { get; set; } = string.Empty;
}