using ATTicket.Domain.AppEntities.Identity;
namespace ATTicket.Application.Features.AppFeatures.UserRoleFeatures.Queries.GetAllUserRoles;
public sealed record GetAllUserRolesQueryResponse(IList<AppUserRole> AppUserRoles);