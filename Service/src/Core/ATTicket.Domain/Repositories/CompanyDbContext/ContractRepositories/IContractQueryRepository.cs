using ATTicket.Domain.CompanyEntities;
using ATTicket.Domain.Repositories.GenericRepositories.CompanyDbContext;

namespace ATTicket.Domain.Repositories.CompanyDbContext.ContractRepositories
{
    public interface IContractQueryRepository: ICompanyDbQueryRepository<Contracts>
    {
    }
}
