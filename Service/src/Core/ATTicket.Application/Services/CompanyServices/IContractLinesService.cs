namespace ATTicket.Application.Services.CompanyServices;
public interface IContractLinesService
{
    Task<IList<ContractLine>> GetAllAsync(string companyId);
    Task<ContractLine> GetByIdAsync(string id, string companyId);
    Task<ContractLine> CreateContractLinesAsync(CreateBasketStatusCommand request, CancellationToken cancellationToken);
    Task<ContractLine> RemoveByIdContractLinesAsync(string id, string companyId);
    Task UpdateAsync(ContractLine contractLine, string companyId);
}
