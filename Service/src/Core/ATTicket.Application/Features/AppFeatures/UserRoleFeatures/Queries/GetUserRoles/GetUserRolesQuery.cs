using ATTicket.Application.Messaging;
namespace ATTicket.Application.Features.AppFeatures.UserRoleFeatures.Queries.GetUserRoles;
public sealed record GetUserRolesQuery(string UserId) : IQuery<GetUserRolesQueryResponse>;