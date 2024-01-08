using ATTicket.Application.Features.CompanyFeatures.TicketPdfDetail.Commands.Create;
using ATTicket.Application.Services.CompanyServices;
using ATTicket.Domain;
using ATTicket.Domain.CompanyEntities;
using ATTicket.Domain.Repositories.CompanyDbContext.ContractRepositories;
using ATTicket.Domain.Repositories.CompanyDbContext.TicketPdfDetail;
using ATTicket.Domain.UnitOfWorks;
using ATTicket.Persistance.Context;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTicket.Persistance.Services.CompanyServices
{
    public sealed class TicketPdfDetailService : ITicketPdfDetailService
    {
        private readonly ITicketPdfDetailCommandRepository _commandRepository;
        private readonly ITicketPdfDetailQuertRepository _queryRepository;
        private readonly IContextService _contextService;
        private readonly ICompanyDbUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private CompanyDbContext _context;

        public TicketPdfDetailService(ITicketPdfDetailCommandRepository commandRepository, ITicketPdfDetailQuertRepository queryRepository, IContextService contextService, ICompanyDbUnitOfWork unitOfWork, IMapper mapper, CompanyDbContext context)
        {
            _commandRepository = commandRepository;
            _queryRepository = queryRepository;
            _contextService = contextService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _context = context;
        }

        public async Task<TicketPdfDetail> CreateTicketPdfDetailAsync(CreateTicketPdfDetailCommand request, CancellationToken cancellationToken)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(request.companyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            TicketPdfDetail ticketPdfDetail = _mapper.Map<TicketPdfDetail>(request);
            await _commandRepository.AddAsync(ticketPdfDetail, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return ticketPdfDetail;
        }

        public async Task<IList<TicketPdfDetail>> GetAllAsync(string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _queryRepository.SetDbContextInstance(_context);
            return await _queryRepository.GetAll().ToListAsync();
        }

        public async Task<TicketPdfDetail> GetByIdAsync(string id, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _queryRepository.SetDbContextInstance(_context);
            return await _queryRepository.GetById(id);
        }

        public async Task<TicketPdfDetail> RemoveByIdTicketPdfDetailAsync(string id, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            _queryRepository.SetDbContextInstance(_context);
            TicketPdfDetail entity = await _queryRepository.GetById(id);
            _commandRepository.Remove(entity);
            await _unitOfWork.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(TicketPdfDetail ticketPdfDetail, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            _commandRepository.Update(ticketPdfDetail);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
