namespace ATTicket.Application.Features.AppFeatures.UserRoleFeatures.Queries.GetUserRoles;
public sealed class GetUserRolesQueryHandler : IQueryHandler<GetUserRolesQuery, GetUserRolesQueryResponse>
{
    private readonly IUserRoleService _userRoleService;

    public GetUserRolesQueryHandler(IUserRoleService userRoleService)
    {
        _userRoleService = userRoleService;
    }

    public async Task<GetUserRolesQueryResponse> Handle(GetUserRolesQuery request, CancellationToken cancellationToken)
    {
        //var result = await _userRoleService.GetListByUserId(request.UserId, cancellationToken);
        //return new(IList<result>);

        IList<string> roles = await _userRoleService.GetListByUserId(request.UserId, cancellationToken);
        return null;
    }
}