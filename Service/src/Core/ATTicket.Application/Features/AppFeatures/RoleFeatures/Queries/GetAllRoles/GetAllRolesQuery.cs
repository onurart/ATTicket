using ATTicket.Application.Messaging;
namespace ATTicket.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles;
public sealed record GetAllRolesQuery() : IQuery<GetAllRolesQueryResponse>;