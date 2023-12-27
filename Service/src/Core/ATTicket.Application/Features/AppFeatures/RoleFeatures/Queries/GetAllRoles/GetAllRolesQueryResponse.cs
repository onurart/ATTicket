using ATTicket.Domain.AppEntities.Identity;
namespace ATTicket.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles;
public sealed record GetAllRolesQueryResponse(IList<AppRole> Roles);