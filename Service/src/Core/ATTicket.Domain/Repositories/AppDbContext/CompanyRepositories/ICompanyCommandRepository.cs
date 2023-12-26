using ATTicket.Domain.AppEntites;
using ATTicket.Domain.Repositories.GenericRepositories.AppDbContext;

namespace ATTicket.Domain.Repositories.AppDbContext.CompanyRepositories
{
    public interface ICompanyCommandRepository : IAppCommandRepository<Company>
    {
    }
}
