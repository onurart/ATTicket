using ATTicket.Application.Features.CompanyFeatures.Contract.Commands.Create;
using ATTicket.Domain.CompanyEntities;

namespace ATTicket.Application.Services.CompanyServices
{
    public interface IContractsService
    {
        Task<IList<Contracts>> GetAllAsync(string companyId);
        Task<Contracts> GetByIdAsync(string id, string companyId);
        Task<Contracts> CreateContractsAsync(CreateContractCommand request, CancellationToken cancellationToken);
        Task<Contracts> RemoveByIdContractsAsync(string id, string companyId);
        Task UpdateAsync(Contracts contracts, string companyId);
    }
}
