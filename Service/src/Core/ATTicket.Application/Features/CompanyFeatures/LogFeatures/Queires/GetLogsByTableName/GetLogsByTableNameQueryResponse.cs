using EntityFrameworkCorePagination.Nuget.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTicket.Application.Features.CompanyFeatures.LogFeatures.Queires.GetLogsByTableName
{
    public sealed record GetLogsByTableNameQueryResponse(PaginationResult<LogDto> Data);
}
