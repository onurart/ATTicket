using ATTicket.Application.Features.CompanyFeatures.ContractLine.Commands.Create;
using ATTicket.Application.Services.CompanyServices;
using ATTicket.Domain;
using ATTicket.Domain.CompanyEntities;
using ATTicket.Domain.Repositories.CompanyDbContext.ContractLinesRepositories;
using ATTicket.Domain.UnitOfWorks;
using ATTicket.Persistance.Context;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ATTicket.Persistance.Services.CompanyServices;
public sealed class ContractLinesService : IContractLinesService
{
    private readonly IContractLinesCommandRepository _contractLinesCommandRepository;
    private readonly IContractLinesQuertRepository _contractLinesQuertRepository;
    private readonly IContextService _contextService;
    private readonly ICompanyDbUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private CompanyDbContext _context;
    public async Task<ContractLine> CreateContractLinesAsync(CreateContactLineCommand request, CancellationToken cancellationToken)
    {
        _context = (CompanyDbContext)_contextService.CreateDbContextInstance(request.companyId);
        _contractLinesCommandRepository.SetDbContextInstance(_context);
        _unitOfWork.SetDbContextInstance(_context);
        ContractLine contractLine = _mapper.Map<ContractLine>(request);
        await _contractLinesCommandRepository.AddAsync(contractLine, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return contractLine;
    }
    public async Task<IList<ContractLine>> GetAllAsync(string companyId)
    {
        _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
        _contractLinesQuertRepository.SetDbContextInstance(_context);
        return await _contractLinesQuertRepository.GetAll().ToListAsync();
    }
    public async Task<ContractLine> GetByIdAsync(string id, string companyId)
    {
        _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
        _contractLinesQuertRepository.SetDbContextInstance(_context);
        return await _contractLinesQuertRepository.GetById(id);
    }

    public async Task<ContractLine> RemoveByIdContractLinesAsync(string id, string companyId)
    {
        _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
        _contractLinesCommandRepository.SetDbContextInstance(_context);
        _unitOfWork.SetDbContextInstance(_context);
        _contractLinesQuertRepository.SetDbContextInstance(_context);
        ContractLine entity = await _contractLinesQuertRepository.GetById(id);
        _contractLinesCommandRepository.Remove(entity);
        await _unitOfWork.SaveChangesAsync();
        return entity;
    }

    public async Task UpdateAsync(ContractLine contractline, string companyId)
    {
        _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
        _contractLinesCommandRepository.SetDbContextInstance(_context);
        _unitOfWork.SetDbContextInstance(_context); 
        _contractLinesCommandRepository.Update(contractline);
        await _unitOfWork.SaveChangesAsync();
    }
}
