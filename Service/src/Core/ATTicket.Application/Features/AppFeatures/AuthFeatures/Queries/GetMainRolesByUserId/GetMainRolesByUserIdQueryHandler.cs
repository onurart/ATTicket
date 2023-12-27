using ATTicket.Application.Messaging;
using ATTicket.Application.Services.AppService;
namespace ATTicket.Application.Features.AppFeatures.AuthFeatures.Queries.GetMainRolesByUserId;
public sealed class GetMainRolesByUserIdQueryHandler : IQueryHandler<GetMainRolesByUserIdQuery, GetMainRolesByUserIdQueryResponse>
{
    private readonly IAuthService _authService;

    public GetMainRolesByUserIdQueryHandler(IAuthService authService)
    {
        _authService = authService;
    }

    public async Task<GetMainRolesByUserIdQueryResponse> Handle(GetMainRolesByUserIdQuery request, CancellationToken cancellationToken)
    {
        string roles = await _authService.GetMainRolesByUserId(request.UserId);
        return new(roles);
    }
}