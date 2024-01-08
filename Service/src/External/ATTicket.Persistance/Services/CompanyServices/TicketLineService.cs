using ATTicket.Application.Features.CompanyFeatures.TicketLine.Commands.Create;
using ATTicket.Application.Services.CompanyServices;
using ATTicket.Domain;
using ATTicket.Domain.CompanyEntities;
using ATTicket.Domain.Repositories.CompanyDbContext.TicketLine;
using ATTicket.Domain.UnitOfWorks;
using ATTicket.Persistance.Context;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ATTicket.Persistance.Services.CompanyServices
{
    public sealed class TicketLineService : ITicketLineService
    {
        private readonly ITİcketLineCommandRepository _commandRepository;
        private readonly ITicketLineQueryRepository _queryRepository;
        private readonly IContextService _contextService;
        private readonly ICompanyDbUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private CompanyDbContext _context;

        public TicketLineService(ITİcketLineCommandRepository commandRepository, ITicketLineQueryRepository queryRepository, IContextService contextService, ICompanyDbUnitOfWork unitOfWork, IMapper mapper, CompanyDbContext context)
        {
            _commandRepository = commandRepository;
            _queryRepository = queryRepository;
            _contextService = contextService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _context = context;
        }

        public async Task<TicketLine> CreateTicketLineAsync(CreateTicketLineCommand request, CancellationToken cancellationToken)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(request.companyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            TicketLine ticketLine = _mapper.Map<TicketLine>(request);
            await _commandRepository.AddAsync(ticketLine, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return ticketLine;
        }

        public async Task<IList<TicketLine>> GetAllAsync(string companyId)
        {

            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _queryRepository.SetDbContextInstance(_context);
            return await _queryRepository.GetAll().ToListAsync();
        }

        public async Task<TicketLine> GetByIdAsync(string id, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _queryRepository.SetDbContextInstance(_context);
            return await _queryRepository.GetById(id);
        }

        public async Task<TicketLine> RemoveByIdTicketLineAsync(string id, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            _queryRepository.SetDbContextInstance(_context);
            TicketLine entity = await _queryRepository.GetById(id);
            _commandRepository.Remove(entity);
            await _unitOfWork.SaveChangesAsync();
            return entity;

        }

        public async Task UpdateAsync(TicketLine ticketLine, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            _commandRepository.Update(ticketLine);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
