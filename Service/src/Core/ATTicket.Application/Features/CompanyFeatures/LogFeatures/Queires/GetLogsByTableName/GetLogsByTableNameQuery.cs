using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTicket.Application.Features.CompanyFeatures.LogFeatures.Queires.GetLogsByTableName
{
  public sealed record GetLogsByTableNameQuery(
      string TableName, 
      string CompanyId,
      int PageNumber = 1,
      int PageSize = 10) : IQuery<GetLogsByTableNameQueryResponse>;
}
