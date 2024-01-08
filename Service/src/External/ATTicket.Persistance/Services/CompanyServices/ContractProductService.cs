using ATTicket.Application.Features.CompanyFeatures.ContractProduct.Commands.Create;
using ATTicket.Application.Services.CompanyServices;
using ATTicket.Domain;
using ATTicket.Domain.CompanyEntities;
using ATTicket.Domain.Repositories.CompanyDbContext.ContractProductRepositories;
using ATTicket.Domain.UnitOfWorks;
using ATTicket.Persistance.Context;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
namespace ATTicket.Persistance.Services.CompanyServices;
public sealed class ContractProductService : IContractProductService
{
    private readonly IContractProductCommandRepository _commandRepository;
    private readonly IContractProductQueryRepository _queryRepository;
    private readonly IContextService _contextService;
    private readonly ICompanyDbUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private CompanyDbContext _context;
    public ContractProductService(IContractProductCommandRepository commandRepository, IContractProductQueryRepository queryRepository, IContextService contextService, ICompanyDbUnitOfWork unitOfWork, IMapper mapper, CompanyDbContext context)
    {
        _commandRepository = commandRepository;
        _queryRepository = queryRepository;
        _contextService = contextService;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _context = context;
    }
    public async Task<ContractProduct> CreateContractProductAsync(CreateContractProductCommad request, CancellationToken cancellationToken)
    {
        _context = (CompanyDbContext)_contextService.CreateDbContextInstance(request.companyId);
        _commandRepository.SetDbContextInstance(_context);
        _unitOfWork.SetDbContextInstance(_context);
        ContractProduct contract = _mapper.Map<ContractProduct>(request);
        await _commandRepository.AddAsync(contract, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return contract;
    }
    public async Task<IList<ContractProduct>> GetAllAsync(string companyId)
    {
        _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
        _queryRepository.SetDbContextInstance(_context);
        return await _queryRepository.GetAll().ToListAsync();
    }
    public async Task<ContractProduct> GetByIdAsync(string id, string companyId)
    {
        _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
        _queryRepository.SetDbContextInstance(_context);
        return await _queryRepository.GetById(id);
    }
    public async Task<ContractProduct> RemoveByIdContractProductAsync(string id, string companyId)
    {
        _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
        _commandRepository.SetDbContextInstance(_context);
        _unitOfWork.SetDbContextInstance(_context);
        _queryRepository.SetDbContextInstance(_context);
        ContractProduct entity = await _queryRepository.GetById(id);
        _commandRepository.Remove(entity);
        await _unitOfWork.SaveChangesAsync();
        return entity;
    }
    public async Task UpdateAsync(ContractProduct contractProduct, string companyId)
    {
        _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
        _commandRepository.SetDbContextInstance(_context);
        _unitOfWork.SetDbContextInstance(_context);
        _commandRepository.Update(contractProduct);
        await _unitOfWork.SaveChangesAsync();
    }
}
