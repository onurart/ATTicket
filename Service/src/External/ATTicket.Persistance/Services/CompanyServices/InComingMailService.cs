using ATTicket.Application.Features.CompanyFeatures.InComingMailSettings.Commands.Create;
using ATTicket.Application.Services.CompanyServices;
using ATTicket.Domain;
using ATTicket.Domain.CompanyEntities;
using ATTicket.Domain.Repositories.CompanyDbContext.InComingMailSettings;
using ATTicket.Domain.UnitOfWorks;
using ATTicket.Persistance.Context;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
namespace ATTicket.Persistance.Services.CompanyServices;
public sealed class InComingMailService : IInComingMailSettingsService
{
    private readonly IInComingMailSettingCommandRepository _commandRepository;
    private readonly IInComingMailSettingsQueryRepository _queryRepository;
    private readonly IContextService _contextService;
    private readonly ICompanyDbUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private CompanyDbContext _context;
    public InComingMailService(IInComingMailSettingCommandRepository commandRepository, IInComingMailSettingsQueryRepository queryRepository, IContextService contextService, ICompanyDbUnitOfWork unitOfWork, IMapper mapper, CompanyDbContext context)
    {
        _commandRepository = commandRepository;
        _queryRepository = queryRepository;
        _contextService = contextService;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _context = context;
    }
    public async Task<InComingMailSettings> CreateInComingMailSettingsAsync(CreateInComingMailSettingCommand request, CancellationToken cancellationToken)
    {
        _context = (CompanyDbContext)_contextService.CreateDbContextInstance(request.companyId);
        _commandRepository.SetDbContextInstance(_context);
        _unitOfWork.SetDbContextInstance(_context);
        InComingMailSettings contract = _mapper.Map<InComingMailSettings>(request);
        await _commandRepository.AddAsync(contract, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return contract;
    }
    public async Task<IList<InComingMailSettings>> GetAllAsync(string companyId)
    {
        _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
        _queryRepository.SetDbContextInstance(_context);
        return await _queryRepository.GetAll().ToListAsync();
    }
    public async Task<InComingMailSettings> GetByIdAsync(string id, string companyId)
    {
        _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
        _queryRepository.SetDbContextInstance(_context);
        return await _queryRepository.GetById(id);
    }
    public async Task<InComingMailSettings> RemoveByIdInComingMailSettingsAsync(string id, string companyId)
    {
        _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
        _commandRepository.SetDbContextInstance(_context);
        _unitOfWork.SetDbContextInstance(_context);
        _queryRepository.SetDbContextInstance(_context);
        InComingMailSettings entity = await _queryRepository.GetById(id);
        _commandRepository.Remove(entity);
        await _unitOfWork.SaveChangesAsync();
        return entity;
    }
    public async Task UpdateAsync(InComingMailSettings inComingMailSettings, string companyId)
    {
        _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
        _commandRepository.SetDbContextInstance(_context);
        _unitOfWork.SetDbContextInstance(_context);
        _commandRepository.Update(inComingMailSettings);
        await _unitOfWork.SaveChangesAsync();
    }
}
