using ATTicket.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using ATTicket.Domain.AppEntities.Identity;

namespace ATTicket.Application.Services.AppService
{
    public interface IRoleService
    {
        Task AddAsync(CreateRoleCommand request);
        Task AddRangeAsync(IEnumerable<AppRole> roles);
        Task UpdateAsync(AppRole appRole);
        Task DeleteAsync(AppRole appRole);
        Task<IList<AppRole>> GetAllRolesAsync();
        Task<AppRole> GetById(string id);
        Task<AppRole> GetByCode(string code);
    }
}
