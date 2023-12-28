using ATTicket.Application.Features.CompanyFeatures.ContractLine.Commands.Create;

namespace ATTicket.Application.Services.CompanyServices;
public interface IContractLinesService
{
    Task<IList<ContractLine>> GetAllAsync(string companyId);
    Task<ContractLine> GetByIdAsync(string id, string companyId);
    Task<ContractLine> CreateContractLinesAsync(CreateContactLineCommand request, CancellationToken cancellationToken);
    Task<ContractLine> RemoveByIdContractLinesAsync(string id, string companyId);
    Task UpdateAsync(ContractLine contractline, string companyId);
}
