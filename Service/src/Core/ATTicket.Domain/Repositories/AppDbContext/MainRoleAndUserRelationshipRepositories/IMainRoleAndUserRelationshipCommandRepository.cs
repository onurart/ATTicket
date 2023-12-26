using ATTicket.Domain.AppEntites;
using ATTicket.Domain.Repositories.GenericRepositories.AppDbContext;

namespace ATTicket.Domain.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories
{
    public interface IMainRoleAndUserRelationshipCommandRepository : IAppCommandRepository<MainRoleAndUserRelationship>
    {
    }
}
