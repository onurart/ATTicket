using ATTicket.Application.Features.CompanyFeatures.ContractDocument.Commands.Create;
using ATTicket.Application.Services.CompanyServices;
using ATTicket.Domain;
using ATTicket.Domain.CompanyEntities;
using ATTicket.Domain.Repositories.CompanyDbContext.ContractDocumentRepositories;
using ATTicket.Domain.Repositories.CompanyDbContext.ContractRepositories;
using ATTicket.Domain.UnitOfWorks;
using ATTicket.Persistance.Context;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;
namespace ATTicket.Persistance.Services.CompanyServices
{
    public class ContractDocumentService : IContractDocumentSerivice
    {
        private readonly IContractDocumentCommandRepository _commandRepository;
        private readonly IContractDocumentQuertRepository _queryRepository;
        private readonly IContextService _contextService;
        private readonly ICompanyDbUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private CompanyDbContext _context;
        public async Task<ContractDocument> CreateContractDocumentAsync(CreateContractDocumentCommand request, CancellationToken cancellationToken)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(request.companyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            ContractDocument contractDocument = _mapper.Map<ContractDocument>(request);
            await _commandRepository.AddAsync(contractDocument,cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return contractDocument;
        }
        public async Task<IList<ContractDocument>> GetAllAsync(string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _queryRepository.SetDbContextInstance(_context);
            return await _queryRepository.GetAll().ToListAsync();
        }
        public async Task<ContractDocument> GetByIdAsync(string id, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _queryRepository.SetDbContextInstance(_context);
            return await _queryRepository.GetById(id);
        }
        public async Task<ContractDocument> RemoveByIdContractDocumentAsync(string id, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            _queryRepository.SetDbContextInstance(_context);
            ContractDocument entity = await _queryRepository.GetById(id);
            _commandRepository.Remove(entity);
            await _unitOfWork.SaveChangesAsync();
            return entity;
        }
        public async Task UpdateAsync(ContractDocument contractdocument, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            _commandRepository.Update(contractdocument);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}       