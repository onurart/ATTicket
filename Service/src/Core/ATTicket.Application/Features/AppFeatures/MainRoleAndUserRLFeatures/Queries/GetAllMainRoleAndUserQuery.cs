using ATTicket.Application.Messaging;

namespace ATTicket.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.Queries;
public sealed record GetAllMainRoleAndUserQuery() : IQuery<GetAllMainRoleAndUserQueryResponse>
{
}