using ATTicket.Application.Features.CompanyFeatures.OutGoingMailSettings.Commands.Create;
using ATTicket.Application.Services.CompanyServices;
using ATTicket.Domain;
using ATTicket.Domain.CompanyEntities;
using ATTicket.Domain.Repositories.CompanyDbContext.OutGoingMailSettings;
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
    public sealed class OutGoingMailSettingService : IOutGoingMailSettings
    {
        private readonly IOutGoingMailSettingsCommandRepository _commandRepository;
        private readonly IOutGoingMailSettingsQuertRepository _quertRepository;
        private readonly IContextService _contextService;
        private readonly ICompanyDbUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private CompanyDbContext _context;
        public OutGoingMailSettingService(IOutGoingMailSettingsCommandRepository commandRepository, IOutGoingMailSettingsQuertRepository quertRepository, IContextService contextService, ICompanyDbUnitOfWork unitOfWork, IMapper mapper, CompanyDbContext context)
        {
            _commandRepository = commandRepository;
            _quertRepository = quertRepository;
            _contextService = contextService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _context = context;
        }

        public async Task<OutGoingMailSettingses> CreateOutGoingMailSettingAsync(CreateOutGoingMailSettingCommand request, CancellationToken cancellationToken)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(request.companyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            OutGoingMailSettingses contract = _mapper.Map<OutGoingMailSettingses>(request);
            await _commandRepository.AddAsync(contract, cancellationToken);
            await _unitOfWork.SaveChangesAsync(cancellationToken);
            return contract;
        }

        public async Task<IList<OutGoingMailSettingses>> GetAllAsync(string companyId)
        {

            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _quertRepository.SetDbContextInstance(_context);
            return await _quertRepository.GetAll().ToListAsync();
        }

        public async Task<OutGoingMailSettingses> GetByIdAsync(string id, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _quertRepository.SetDbContextInstance(_context);
            return await _quertRepository.GetById(id);
        }

        public async Task<OutGoingMailSettingses> RemoveByIdOutGoingMailSettingsAsync(string id, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            _quertRepository.SetDbContextInstance(_context);
            OutGoingMailSettingses entity = await _quertRepository.GetById(id);
            _commandRepository.Remove(entity);
            await _unitOfWork.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(OutGoingMailSettingses outGoingMailSettingses, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _commandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            _commandRepository.Update(outGoingMailSettingses);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
