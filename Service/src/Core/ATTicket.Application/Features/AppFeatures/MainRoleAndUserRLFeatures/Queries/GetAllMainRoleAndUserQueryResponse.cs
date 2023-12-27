using ATTicket.Domain.AppEntities;
namespace ATTicket.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.Queries;
public sealed record GetAllMainRoleAndUserQueryResponse(List<MainRoleAndUserRelationship> mainRoleAndUserRelationships)
{
}