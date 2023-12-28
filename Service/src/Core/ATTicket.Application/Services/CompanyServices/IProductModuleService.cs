using ATTicket.Application.Features.CompanyFeatures.ContractOrder.Commands.Create;
using ATTicket.Application.Features.CompanyFeatures.ProductModule.Commands.Create;
using ATTicket.Domain.CompanyEntities;

namespace ATTicket.Application.Services.CompanyServices
{
    public interface IProductModuleService
    {
        Task<IList<ProductModule>> GetAllAsync(string companyId);
        Task<ProductModule> GetByIdAsync(string id, string companyId);
        Task<ProductModule> CreateContractOrderAsync(CreateProductModuleComand request, CancellationToken cancellationToken);
        Task<ProductModule> RemoveByIdContractOrderAsync(string id, string companyId);
        Task UpdateAsync(ProductModule productModule , string companyId);
    }
}
