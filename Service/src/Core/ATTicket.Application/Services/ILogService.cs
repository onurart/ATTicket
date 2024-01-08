using ATTicket.Application.Features.CompanyFeatures.LogFeatures.Queires.GetLogsByTableName;
using EntityFrameworkCorePagination.Nuget.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTicket.Application.Services
{
    public interface ILogService
    {
        Task AddAsync(Log log, string companyId);
        Task<PaginationResult<LogDto>> GetAllByTableName(GetLogsByTableNameQuery request);
    }
}
