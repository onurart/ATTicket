using ATTicket.Domain.AppEntites;
using ATTicket.Domain.Repositories.GenericRepositories.AppDbContext;

namespace ATTicket.Domain.Repositories.AppDbContext.UserAndCompanyRelationshipRepositories
{
    public interface IUserAndCompanyRelationshipCommandRepository : IAppCommandRepository<UserAndCompanyRelationship>
    {
    }
}
