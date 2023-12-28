using ATTicket.Application.Features.CompanyFeatures.ContractProduct.Commands.Create;

namespace ATTicket.Application.Services.CompanyServices;
public interface IContractProductService
{
    Task<IList<ContractProduct>> GetAllAsync(string companyId);
    Task<ContractProduct> GetByIdAsync(string id, string companyId);
    Task<ContractProduct> CreateContractProductAsync(CreateContractProductCommad request, CancellationToken cancellationToken);
    Task<ContractProduct> RemoveByIdContractProductAsync(string id, string companyId);
    Task UpdateAsync(ContractProduct contractProduct, string companyId);
}
