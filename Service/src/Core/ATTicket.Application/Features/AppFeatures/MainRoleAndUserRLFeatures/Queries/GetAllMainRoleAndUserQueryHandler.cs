using Microsoft.EntityFrameworkCore;

namespace ATTicket.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.Queries;
public sealed class GetAllMainRoleAndUserQueryHandler : IQueryHandler<GetAllMainRoleAndUserQuery, GetAllMainRoleAndUserQueryResponse>
{
    private readonly IMainRoleAndUserRelationshipService _roleAndUserRelationshipService;

    public GetAllMainRoleAndUserQueryHandler(IMainRoleAndUserRelationshipService roleAndUserRelationshipService)
    {
        _roleAndUserRelationshipService = roleAndUserRelationshipService;
    }

    public async Task<GetAllMainRoleAndUserQueryResponse> Handle(GetAllMainRoleAndUserQuery request, CancellationToken cancellationToken)
    {
        return new(await _roleAndUserRelationshipService
             .GetAll()
             .Include("User")
             .Include("MainRole")
             .ToListAsync());
    }
}