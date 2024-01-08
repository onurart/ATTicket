using ATTicket.Domain.UnitOfWorks;
using ATTicket.Domain;
using ATTicket.Persistance.Context;
using ATTicket.Application.Services.CompanyServices;
using AutoMapper;
using ATTicket.Domain.CompanyEntities;
using ATTicket.Application.Features.CompanyFeatures.MailDocument.Commands.Create;
using ATTicket.Domain.Repositories.CompanyDbContext.MailDocument;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace ATTicket.Persistance.Services.CompanyServices
{
    public sealed class MailDocumentService : IMailDocumentService
    {
        private readonly IMailDocumentCommandrRepository _commandRepository;
        private readonly IMailDocumentQuertRepository _queryRepository;
        private readonly IContextService _contextService;
        private readonly ICompanyDbUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private CompanyDbContext _context;
        public MailDocumentService(IMailDocumentQuertRepository queryRepository, IContextService contextService, ICompanyDbUnitOfWork unitOfWork, IMapper mapper, CompanyDbContext context)
        {
            _queryRepository = queryRepository;
            _contextService = contextService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _context = context;
        }

        public async Task<MailDocuments> CreateMailDocumentsAsync(CreateMailDocumentsCommand request, CancellationToken cancellationToken)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(request.companyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            MailDocuments contract = _mapper.Map<MailDocuments>(request);
            await _commandRepository.AddAsync(contract, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return contract;
        }

        public async Task<IList<MailDocuments>> GetAllAsync(string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _queryRepository.SetDbContextInstance(_context);
            return await _queryRepository.GetAll().ToListAsync();

        }

        public async Task<MailDocuments> GetByIdAsync(string id, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _queryRepository.SetDbContextInstance(_context);
            return await _queryRepository.GetById(id);
        }

        public async Task<MailDocuments> RemoveByIdMailDocumentsAsync(string id, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            _queryRepository.SetDbContextInstance(_context);
            MailDocuments entity = await _queryRepository.GetById(id);
            _commandRepository.Remove(entity);
            await _unitOfWork.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(MailDocuments mailDocuments, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            _commandRepository.Update(mailDocuments);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
