using ATTicket.Application.Features.CompanyFeatures.Contract.Commands.Create;
using ATTicket.Application.Services.CompanyServices;
using ATTicket.Domain;
using ATTicket.Domain.CompanyEntities;
using ATTicket.Domain.Repositories.AppDbContext.CompanyRepositories;
using ATTicket.Domain.Repositories.CompanyDbContext.ContractRepositories;
using ATTicket.Domain.UnitOfWorks;
using ATTicket.Persistance.Context;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
namespace ATTicket.Persistance.Services.CompanyServices
{
    public sealed class ContractService : IContractsService
    {
        private readonly IContractCommandRepository _commandRepository;
        private readonly IContractQueryRepository _queryRepository;
        private readonly IContextService _contextService;
        private readonly ICompanyDbUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private CompanyDbContext _context;
        public ContractService(IContextService contextService, ICompanyDbUnitOfWork unitOfWork, IMapper mapper, ICompanyQueryRepository companyQueryRepository, IHttpClientFactory httpClientFactory, IContractCommandRepository commandRepository = null, IContractQueryRepository queryRepository = null)
        {
            _contextService = contextService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _commandRepository = commandRepository;
            _queryRepository = queryRepository;
        }
        public async Task<Contracts> CreateProductAsync(CreateContractCommand request, CancellationToken cancellationToken)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(request.companyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            Contracts contract = _mapper.Map<Contracts>(request);
            await _commandRepository.AddAsync(contract, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return contract;
        }
        public async Task<IList<Contracts>> GetAllAsync(string companyId)
        {

            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _queryRepository.SetDbContextInstance(_context);
            return await _queryRepository.GetAll().ToListAsync();
        }
        public async Task<Contracts> GetByIdAsync(string id, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _queryRepository.SetDbContextInstance(_context);
            return await _queryRepository.GetById(id);
        }
        public async Task<Contracts> RemoveByIdContractsAsync(string id, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            _queryRepository.SetDbContextInstance(_context);
            Contracts entity = await _queryRepository.GetById(id);
            _commandRepository.Remove(entity);
            await _unitOfWork.SaveChangesAsync();
            return entity;
        }
        public async Task UpdateAsync(Contracts contracts, string companyId)
        {
                            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
                            _commandRepository.SetDbContextInstance(_context);
                            _unitOfWork.SetDbContextInstance(_context);
                            _commandRepository.Update(contracts);
                            await _unitOfWork.SaveChangesAsync();
        }
    }
}