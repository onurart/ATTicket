using ATTicket.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTicket.Application.Features.CompanyFeatures.LogFeatures.Queires.GetLogsByTableName
{
    public sealed class GetLogsByTableNameQueryHandler : IQueryHandler<GetLogsByTableNameQuery, GetLogsByTableNameQueryResponse>
    {
        private readonly ILogService _logService;

        public GetLogsByTableNameQueryHandler(ILogService logService)
        {
            _logService = logService;
        }

        public async Task<GetLogsByTableNameQueryResponse> Handle(GetLogsByTableNameQuery request, CancellationToken cancellationToken)
        {
            return new(await _logService.GetAllByTableName(request));
        }
    }
    }
