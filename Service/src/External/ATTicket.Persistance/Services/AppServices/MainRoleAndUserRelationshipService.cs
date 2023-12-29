using ATTicket.Application.Services.AppService;
using ATTicket.Domain.AppEntities;
using ATTicket.Domain.Repositories.AppDbContext.MainRoleAndUserRelationshipRepositories;
using ATTicket.Domain.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
namespace ATTicket.Persistance.Services.AppServices
{
    public sealed class MainRoleAndUserRelationshipService : IMainRoleAndUserRelationshipService
    {
        private readonly IMainRoleAndUserRelationshipCommandRepository _commandRepository;
        private readonly IMainRoleAndUserRelationshipQueryRepository _queryRepository;
        private readonly IAppUnitOfWork _unitOfWork;
        public MainRoleAndUserRelationshipService(IMainRoleAndUserRelationshipCommandRepository commandRepository, IMainRoleAndUserRelationshipQueryRepository queryRepository, IAppUnitOfWork unitOfWork)
        {
            _commandRepository = commandRepository;
            _queryRepository = queryRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task CreateAsync(MainRoleAndUserRelationship mainRoleAndUserRelationship, CancellationToken cancellationToken)
        {
            await _commandRepository.AddAsync(mainRoleAndUserRelationship, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
        }
        public IQueryable<MainRoleAndUserRelationship> GetAll()
        {
            return _queryRepository.GetAll();
        }
        public async Task<MainRoleAndUserRelationship> GetByIdAsync(string id, bool tracking)
        {
            MainRoleAndUserRelationship entity = await _queryRepository.GetById(id, tracking);
            return entity;
        }
        public async Task<MainRoleAndUserRelationship> GetByUserIdCompanyIdAndMainRoleIdAsync(string userId, string mainRoleId, CancellationToken cancellationToken)
        {
            return await _queryRepository.GetFirstByExpiression(x => x.UserId == userId && x.MainRoleId == mainRoleId, cancellationToken);
        }
        public async Task<MainRoleAndUserRelationship> GetMainRolesByUserId(string userId)
        {
            return await _queryRepository.GetWhere(x => x.UserId == userId).Include("MainRole").FirstOrDefaultAsync();
        }
        public async Task<MainRoleAndUserRelationship> GetRolesByUserIdAndCompanyId(string userId, string companyId)
        {
            return await _queryRepository.GetFirstByExpiression(x => x.UserId == userId, default);
        }
        public async Task RemoveByIdAsync(string id)
        {
            await _commandRepository.RemoveById(id);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
