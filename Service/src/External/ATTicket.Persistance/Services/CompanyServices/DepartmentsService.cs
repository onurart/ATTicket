using ATTicket.Application.Features.CompanyFeatures.Department.Commands.Create;
using ATTicket.Application.Services.CompanyServices;
using ATTicket.Domain;
using ATTicket.Domain.CompanyEntities;
using ATTicket.Domain.Repositories.CompanyDbContext.DepartmentRepositories;
using ATTicket.Domain.UnitOfWorks;
using ATTicket.Persistance.Context;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
namespace ATTicket.Persistance.Services.CompanyServices
{
    public sealed class DepartmentsService : IDepartmentService
    {
        private readonly IDepartmentCommandRepository _commandRepository;
        private readonly IDepartmentQueryRepositorı _queryRepositor;
        private readonly IContextService _contextService;
        private readonly ICompanyDbUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private CompanyDbContext _context;
        public DepartmentsService(IDepartmentCommandRepository commandRepository, IDepartmentQueryRepositorı queryRepositor, IContextService contextService, ICompanyDbUnitOfWork unitOfWork, IMapper mapper, CompanyDbContext context)
        {
            _commandRepository = commandRepository;
            _queryRepositor = queryRepositor;
            _contextService = contextService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _context = context;
        }
        public async Task<Departments> CreateDepartmentAsync(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(request.companyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            Departments contract = _mapper.Map<Departments>(request);
            await _commandRepository.AddAsync(contract, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return contract;
        }
        public async Task<IList<Departments>> GetAllAsync(string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _queryRepositor.SetDbContextInstance(_context);
            return await _queryRepositor.GetAll().ToListAsync();
        }
        public async Task<Departments> GetByIdAsync(string id, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _queryRepositor.SetDbContextInstance(_context);
            return await _queryRepositor.GetById(id);
        }
        public async Task<Departments> RemoveByIdDepartmentAsync(string id, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            _queryRepositor.SetDbContextInstance(_context);
            Departments entity = await _queryRepositor.GetById(id);
            _commandRepository.Remove(entity);
            await _unitOfWork.SaveChangesAsync();
            return entity;
        }
        public async Task UpdateAsync(Departments departments, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            _commandRepository.Update(departments);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
