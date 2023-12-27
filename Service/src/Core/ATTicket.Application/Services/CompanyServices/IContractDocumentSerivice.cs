namespace ATTicket.Application.Services.CompanyServices;
public interface IContractDocumentSerivice
{
    Task<IList<ContractDocument>> GetAllAsync(string companyId);
    Task<ContractDocument> GetByIdAsync(string id, string companyId);
    Task<ContractDocument> CreateContractDocumentAsync(CreateBasketStatusCommand request, CancellationToken cancellationToken);
    Task<ContractDocument> RemoveByIdContractDocumentAsync(string id, string companyId);
    Task UpdateAsync(ContractDocument contractDocument, string companyId);
}