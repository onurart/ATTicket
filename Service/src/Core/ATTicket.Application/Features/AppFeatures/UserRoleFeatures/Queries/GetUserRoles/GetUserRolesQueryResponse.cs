using ATTicket.Domain.AppEntities.Identity;
namespace ATTicket.Application.Features.AppFeatures.UserRoleFeatures.Queries.GetUserRoles;
public sealed record GetUserRolesQueryResponse(IList<AppUserRole> AppUserRoles);