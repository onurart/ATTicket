using ATTicket.Application.Features.CompanyFeatures.ViewContract.Commands.Create;

namespace ATTicket.Application.Services.CompanyServices;
public interface IViewContractService
{
    Task<IList<ViewContract>> GetAllAsync(string companyId);
    Task<ViewContract> GetByIdAsync(string id, string companyId);
    Task<ViewContract> CreateViewContractAsync(CreateViewContractCommand request, CancellationToken cancellationToken);
    Task<ViewContract> RemoveByIdViewContractAsync(string id, string companyId);
    Task UpdateAsync(ViewContract viewContract, string companyId);
}
