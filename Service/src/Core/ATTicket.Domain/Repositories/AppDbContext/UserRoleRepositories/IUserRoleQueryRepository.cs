using ATTicket.Domain.AppEntities.Identity;
using ATTicket.Domain.Repositories.GenericRepositories.AppDbContext;
namespace ATTicket.Domain.Repositories.AppDbContext.UserRoleRepositories;
public interface IUserRoleQueryRepository : IAppQueryRepository<AppUserRole>
{
}