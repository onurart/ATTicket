using ATTicket.Application.Features.CompanyFeatures.Ticket.Commands.Create;
using ATTicket.Application.Services.CompanyServices;
using ATTicket.Domain;
using ATTicket.Domain.CompanyEntities;
using ATTicket.Domain.Repositories.CompanyDbContext.ContractRepositories;
using ATTicket.Domain.Repositories.CompanyDbContext.Ticket;
using ATTicket.Domain.Repositories.CompanyDbContext.TicketMail;
using ATTicket.Domain.UnitOfWorks;
using ATTicket.Persistance.Context;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace ATTicket.Persistance.Services.CompanyServices
{
    public sealed class TicketService : ITicketServixe
    {
        private readonly ITicketCommandRepository _commandRepository;
        private readonly Domain.Repositories.CompanyDbContext.Ticket.ITicketQuertRepository _queryRepository;
        private readonly IContextService _contextService;
        private readonly ICompanyDbUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private CompanyDbContext _context;

        public TicketService(ITicketCommandRepository commandRepository, Domain.Repositories.CompanyDbContext.Ticket.ITicketQuertRepository queryRepository, IContextService contextService, ICompanyDbUnitOfWork unitOfWork, IMapper mapper, CompanyDbContext context)
        {
            _commandRepository = commandRepository;
            _queryRepository = queryRepository;
            _contextService = contextService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _context = context;
        }

        public async Task<Tickets> CreateTicketAsync(CreateTicketCommand request, CancellationToken cancellationToken)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(request.companyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            Tickets tickets = _mapper.Map<Tickets>(request);
            await _commandRepository.AddAsync(tickets, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return tickets;
        }

        public async Task<IList<Tickets>> GetAllAsync(string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _queryRepository.SetDbContextInstance(_context);
            return await _queryRepository.GetAll().ToListAsync();
        }

        public async Task<Tickets> GetByIdAsync(string id, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _queryRepository.SetDbContextInstance(_context);
            return await _queryRepository.GetById(id);
        }

        public async Task<Tickets> RemoveByIdTicketAsync(string id, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            _queryRepository.SetDbContextInstance(_context);
            Tickets entity = await _queryRepository.GetById(id);
            _commandRepository.Remove(entity);
            await _unitOfWork.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Tickets ticket, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            _commandRepository.Update(ticket);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
