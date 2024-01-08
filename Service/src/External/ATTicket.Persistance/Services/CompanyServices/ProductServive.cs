using ATTicket.Application.Features.CompanyFeatures.Product.Commands.Create;
using ATTicket.Application.Services.CompanyServices;
using ATTicket.Domain;
using ATTicket.Domain.CompanyEntities;
using ATTicket.Domain.Repositories.CompanyDbContext.ContractRepositories;
using ATTicket.Domain.Repositories.CompanyDbContext.Product;
using ATTicket.Domain.UnitOfWorks;
using ATTicket.Persistance.Context;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;
namespace ATTicket.Persistance.Services.CompanyServices
{
    public sealed class ProductServive : IProductService
    {
        private readonly IProductCommadRepositoru _commandRepository;
        private readonly IProductQueryRepository _queryRepository;
        private readonly IContextService _contextService;
        private readonly ICompanyDbUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private CompanyDbContext _context;
        public ProductServive(IProductCommadRepositoru commandRepository, IProductQueryRepository queryRepository, IContextService contextService, ICompanyDbUnitOfWork unitOfWork, IMapper mapper, CompanyDbContext context)
        {
            _commandRepository = commandRepository;
            _queryRepository = queryRepository;
            _contextService = contextService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _context = context;
        }
        public async Task<Product> CreateProductAsync(CreateProductCommand request, CancellationToken cancellationToken)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(request.companyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            Product contract = _mapper.Map<Product>(request);
            await _commandRepository.AddAsync(contract, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return contract;
        }
        public async Task<IList<Product>> GetAllAsync(string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _queryRepository.SetDbContextInstance(_context);
            return await _queryRepository.GetAll().ToListAsync();
        }
        public async Task<Product> GetByIdAsync(string id, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _queryRepository.SetDbContextInstance(_context);
            return await _queryRepository.GetById(id);
        }
        public async Task<Product> RemoveByIdProductAsync(string id, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            _queryRepository.SetDbContextInstance(_context);
            Product entity = await _queryRepository.GetById(id);
            _commandRepository.Remove(entity);
            await _unitOfWork.SaveChangesAsync();
            return entity;
        }
        public async Task UpdateAsync(Product product, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            _commandRepository.Update(product);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
