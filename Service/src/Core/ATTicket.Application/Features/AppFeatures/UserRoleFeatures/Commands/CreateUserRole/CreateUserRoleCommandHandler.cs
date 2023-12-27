namespace ATTicket.Application.Features.AppFeatures.UserRoleFeatures.Commands.CreateUserRole;
public sealed class CreateUserRoleCommandHandler : ICommandHandler<CreateUserRoleCommand, CreateUserRoleCommandResponse>
{
    private readonly IUserRoleService _userRoleService;
    public CreateUserRoleCommandHandler(IUserRoleService userRoleService)
    {
        _userRoleService = userRoleService;
    }
    public async Task<CreateUserRoleCommandResponse> Handle(CreateUserRoleCommand request, CancellationToken cancellationToken)
    {
        AppUserRole userRole = await _userRoleService.GetByUserIdAndRoleIdAsync(request.UserId, request.RoleId);
        if (userRole != null) throw new Exception("Bu rol daha önce kayıt edilmiş!");
        AppUserRole appUserRole = new
            (
            Guid.NewGuid().ToString(),
            request.RoleId,
            request.UserId
            );
        await _userRoleService.AddAsync(appUserRole, cancellationToken);
        return new();
    }
}