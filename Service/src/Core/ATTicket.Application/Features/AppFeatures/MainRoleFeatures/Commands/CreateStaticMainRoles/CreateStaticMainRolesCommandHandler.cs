using ATTicket.Domain.Roles;

namespace ATTicket.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRoles;
public sealed class CreateStaticMainRolesCommandHandler : ICommandHandler<CreateStaticMainRolesCommand, CreateStaticMainRolesCommandResponse>
{
    private readonly IMainRoleService _mainRoleService;
    public CreateStaticMainRolesCommandHandler(IMainRoleService mainRoleService)
    {
        _mainRoleService = mainRoleService;
    }
    public async Task<CreateStaticMainRolesCommandResponse> Handle(CreateStaticMainRolesCommand request, CancellationToken cancellationToken)
    {
        List<MainRole> mainRoles = RoleList.GetStaticMainRoles();
        List<MainRole> newMainRoles = new List<MainRole>();
        foreach (var mainRole in mainRoles)
        {
            MainRole checkMainRole = await _mainRoleService.GetByTitleAndCompanyId(mainRole.Title, cancellationToken);
            if (checkMainRole == null) newMainRoles.Add(mainRole);
        }

        await _mainRoleService.CreateRangeAsync(newMainRoles, cancellationToken);
        return new();
    }
}