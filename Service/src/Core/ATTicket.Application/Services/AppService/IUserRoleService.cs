namespace ATTicket.Application.Services.AppService
{
    public interface IUserRoleService
    {
        Task AddAsync(AppUserRole appUserRole, CancellationToken cancellationToken);
        Task AddRangeAsync(IEnumerable<AppUserRole> roles, CancellationToken cancellationToken);
        Task UpdateAsync(AppUserRole appRole);
        Task DeleteAsync(AppUserRole appRole);
        IQueryable<AppUserRole> GetAllRolesAsync();
        Task<IList<string>> GetListByUserId(string userId, CancellationToken cancellationToken);
        Task<AppUserRole> GetById(string id);
        Task<AppUserRole> GetByUserIdAndRoleIdAsync(string userId, string roleid);
    }
}
