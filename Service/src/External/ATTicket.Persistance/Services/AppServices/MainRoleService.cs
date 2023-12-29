using ATTicket.Application.Services.AppService;
using ATTicket.Domain.AppEntities;
using ATTicket.Domain.Repositories.AppDbContext.MainRoleReporistories;
using ATTicket.Domain.UnitOfWorks;
namespace ATTicket.Persistance.Services.AppServices;
public sealed class MainRoleService : IMainRoleService
{
    private readonly IMainRoleCommandRepository _mainRoleCommandRepository;
    private readonly IMainRoleQueryRepository _mainRoleQueryRepository;
    private readonly IAppUnitOfWork _unitOfWork;
    public MainRoleService(IMainRoleCommandRepository mainRoleCommandRepository, IMainRoleQueryRepository mainRoleQueryRepository, IAppUnitOfWork unitOfWork)
    {
        _mainRoleCommandRepository = mainRoleCommandRepository;
        _mainRoleQueryRepository = mainRoleQueryRepository;
        _unitOfWork = unitOfWork;
    }
    public async Task CreateAsync(MainRole mainRole, CancellationToken cancellationToken)
    {
        await _mainRoleCommandRepository.AddAsync(mainRole, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
    public async Task CreateRangeAsync(List<MainRole> newMainRoles, CancellationToken cancellationToken)
    {
        await _mainRoleCommandRepository.AddRangeAsync(newMainRoles, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
    public IQueryable<MainRole> GetAll()
    {
        return _mainRoleQueryRepository.GetAll();
    }
    public async Task<MainRole> GetByIdAsync(string id)
    {
        return await _mainRoleQueryRepository.GetById(id);
    }
    public async Task<MainRole> GetByTitleAndCompanyId(string title, CancellationToken cancellationToken)
    {
        return await _mainRoleQueryRepository.GetFirstByExpiression(p => p.Title == title, cancellationToken, false);
    }
    public async Task RemoveByIdAsync(string id)
    {
        await _mainRoleCommandRepository.RemoveById(id);
        await _unitOfWork.SaveChangesAsync();
    }
    public async Task UpdateAsync(MainRole mainRole)
    {
        _mainRoleCommandRepository.Update(mainRole);
        await _unitOfWork.SaveChangesAsync();
    }
}
