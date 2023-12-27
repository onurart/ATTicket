using Microsoft.EntityFrameworkCore;
namespace ATTicket.Application.Features.AppFeatures.UserRoleFeatures.Queries.GetAllUserRoles;
public sealed class GetAllUserRolesQueryHandler : IQueryHandler<GetAllUserRolesQuery, GetAllUserRolesQueryResponse>
{
    private readonly IUserRoleService _roleService;

    public GetAllUserRolesQueryHandler(IUserRoleService roleService)
    {
        _roleService = roleService;
    }

    public async Task<GetAllUserRolesQueryResponse> Handle(GetAllUserRolesQuery request, CancellationToken cancellationToken)
    {
        //var result = _roleService.GetAllRolesAsync();
        //return new(await result.ToListAsync());

        return new(await _roleService.GetAllRolesAsync()
            .Include("AppRole")
            .Include("User")
            .ToListAsync());
    }
}