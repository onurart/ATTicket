using ATTicket.Application.Features.CompanyFeatures.MailDocument.Commands.Create;

namespace ATTicket.Application.Services.CompanyServices
{
    public interface IMailDocumentService
    {
        Task<IList<MailDocuments>> GetAllAsync(string companyId);
        Task<MailDocuments> GetByIdAsync(string id, string companyId);
        Task<MailDocuments> CreateMailDocumentsAsync(CreateMailDocumentsCommand request, CancellationToken cancellationToken);
        Task<MailDocuments> RemoveByIdMailDocumentsAsync(string id, string companyId);
        Task UpdateAsync(MailDocuments mailDocuments, string companyId);
    }
}
