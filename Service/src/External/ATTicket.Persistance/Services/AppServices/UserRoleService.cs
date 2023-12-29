using ATTicket.Application.Services.AppService;
using ATTicket.Domain.AppEntities.Identity;
using ATTicket.Domain.Repositories.AppDbContext.UserRoleRepositories;
using ATTicket.Domain.UnitOfWorks;
using Microsoft.EntityFrameworkCore;

namespace ATTicket.Persistance.Services.AppServices;
public sealed class UserRoleService : IUserRoleService
{
    private readonly IUserRoleCommandRepository _commandRepository;
    private readonly IUserRoleQueryRepository _queryRepository;
    private readonly IAppUnitOfWork _unitOfWork;
    public UserRoleService(IUserRoleCommandRepository commandRepository, IUserRoleQueryRepository queryRepository, IAppUnitOfWork unitOfWork)
    {
        _commandRepository = commandRepository;
        _queryRepository = queryRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task AddAsync(AppUserRole appUserRole, CancellationToken cancellationToken)
    {
        await _commandRepository.AddAsync(appUserRole, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
    public async Task AddRangeAsync(IEnumerable<AppUserRole> roles, CancellationToken cancellationToken)
    {
        await _commandRepository.AddRangeAsync(roles, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
    public async Task DeleteAsync(AppUserRole appRole)
    {
        _commandRepository.Remove(appRole);
        await _unitOfWork.SaveChangesAsync();
    }
    public async Task<AppUserRole> GetById(string id)
    {
        return await _queryRepository.GetById(id);
    }
    public async Task<IList<AppUserRole>> GetUserRolesAsync(string userid, CancellationToken cancellationToken)
    {
        return await _queryRepository.GetWhere(p => p.UserId == userid).Include("AppRole").ToListAsync();
    }
    public async Task UpdateAsync(AppUserRole appRole)
    {
        _commandRepository.Update(appRole);
        await _unitOfWork.SaveChangesAsync();
    }
    public IQueryable<AppUserRole> GetAllRolesAsync()
    {
        return _queryRepository.GetAll();
    }
    public async Task<IList<string>> GetListByUserId(string userId, CancellationToken cancellationToken)
    {
        List<AppUserRole> appUserRole = await _queryRepository.GetWhere(x => x.UserId == userId).Include("AppRole").ToListAsync();
        IList<string> roles = appUserRole.Select(s => s.AppRole.Code).ToList();
        return roles;
        //return List<appUserRole.AppRole.Code>;
    }

    public async Task<AppUserRole> GetByUserIdAndRoleIdAsync(string userId, string roleid)
    {
        return await _queryRepository.GetWhere(x => x.UserId == userId && x.RoleId == roleid).FirstOrDefaultAsync();
    }
}
