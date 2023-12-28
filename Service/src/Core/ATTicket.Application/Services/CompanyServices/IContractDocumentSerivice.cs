using ATTicket.Application.Features.CompanyFeatures.ContractDocument.Commands.Create;

namespace ATTicket.Application.Services.CompanyServices;
public interface IContractDocumentSerivice
{
    Task<IList<ContractDocument>> GetAllAsync(string companyId);
    Task<ContractDocument> GetByIdAsync(string id, string companyId);
    Task<ContractDocument> CreateContractDocumentAsync(CreateContractDocumentCommand request, CancellationToken cancellationToken);
    Task<ContractDocument> RemoveByIdContractDocumentAsync(string id, string companyId);
    Task UpdateAsync(ContractDocument contractdocument, string companyId);
}