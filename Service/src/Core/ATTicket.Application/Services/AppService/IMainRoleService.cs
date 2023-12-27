namespace ATTicket.Application.Services.AppService
{
    public interface IMainRoleService
    {
        Task<MainRole> GetByTitleAndCompanyId(string title, CancellationToken cancellationToken);
        Task CreateAsync(MainRole mainRole, CancellationToken cancellationToken);
        Task CreateRangeAsync(List<MainRole> newMainRoles, CancellationToken cancellationToken);
        IQueryable<MainRole> GetAll();
        Task RemoveByIdAsync(string id);
        Task<MainRole> GetByIdAsync(string id);
        Task UpdateAsync(MainRole mainRole);
    }
}
