namespace ATTicket.Application.Features.CompanyFeatures.MailDocument.Commands.Create;
public sealed record CreateMailDocumentsCommand
                      (
                         int MailId,
                         string UploadedFile,
                         string UploadedFileName,
                         string UploadedFileContentType) : ICommand<CreateMailDocumentsCommandReponse>;