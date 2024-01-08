using ATTicket.Application.Features.CompanyFeatures.LogFeatures.Queires.GetLogsByTableName;
using ATTicket.Application.Services;
using ATTicket.Domain.AppEntities.Identity;
using ATTicket.Domain.CompanyEntities;
using ATTicket.Domain.Dtos;
using ATTicket.Domain.UnitOfWorks;
using ATTicket.Domain;
using ATTicket.Persistance.Context;
using EntityFrameworkCorePagination.Nuget.Pagination;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATTicket.Domain.Repositories.CompanyDbContext.LogRepositories;

namespace ATTicket.Persistance.Services.CompanyServices
{
    public class LogService : ILogService
    {
        private CompanyDbContext _context;
        private readonly IContextService _contextService;
        private readonly ILogCommandRepository _logCommandRepository;
        private readonly ILogQueryRepository _logQueryRepository;
        private readonly ICompanyDbUnitOfWork _unitOfWork;
        private readonly UserManager<AppUser> _userManager;
        public LogService(IContextService contextService, ILogCommandRepository logCommandRepository, ILogQueryRepository logQueryRepository, ICompanyDbUnitOfWork unitOfWork, UserManager<AppUser> userManager)
        {
            _contextService = contextService;
            _logCommandRepository = logCommandRepository;
            _logQueryRepository = logQueryRepository;
            _unitOfWork = unitOfWork;
            _userManager = userManager;
        }
        public async Task AddAsync(Log log, string companyId)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(companyId);
            _logCommandRepository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);
            await _logCommandRepository.AddAsync(log, default);
            await _unitOfWork.SaveChangesAsync();
        }
        public async Task<PaginationResult<LogDto>> GetAllByTableName(GetLogsByTableNameQuery request)
        {
            _context = (CompanyDbContext)_contextService.CreateDbContextInstance(request.CompanyId);
            _logQueryRepository.SetDbContextInstance(_context);

            PaginationResult<Log> result = await _logQueryRepository.GetAll(false).OrderByDescending(p => p.CreatedDate).ToPagedListAsync(request.PageNumber, request.PageSize);

            int count = _logQueryRepository.GetAll().Count();

            IList<LogDto> logDtos = new List<LogDto>();

            if (result.Datas != null)
            {
                foreach (var item in result.Datas)
                {
                    AppUser user = await _userManager.FindByIdAsync(item.UserId);
                    LogDto logDto = new()
                    {
                        Id = item.Id,
                        CreatedDate = item.CreatedDate,
                        Data = item.Data,
                        TableName = item.TableName,
                        Progress = item.Progress,
                        UserId = item.UserId,
                        UserEmail = user?.Email,
                        UserName = $"{user?.FirstName} {user?.LastName}"
                    };
                    logDtos.Add(logDto);
                }
            }
            PaginationResult<LogDto> requestResult = new(
                pageNumber: result.PageNumber,
                pageSize: result.PageSize,
                totalCount: count,
                datas: logDtos);

            return requestResult;
        }
    }
}
