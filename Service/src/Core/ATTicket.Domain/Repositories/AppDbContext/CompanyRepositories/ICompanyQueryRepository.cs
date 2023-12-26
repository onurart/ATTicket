using ATTicket.Domain.AppEntites;
using ATTicket.Domain.Repositories.GenericRepositories.AppDbContext;

namespace ATTicket.Domain.Repositories.AppDbContext.CompanyRepositories
{
    public interface ICompanyQueryRepository : IAppQueryRepository<Company>
    {
    }
}
