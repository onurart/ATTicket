using ATTicket.Application.Messaging;
using ATTicket.Application.Services.AppService;
using ATTicket.Domain.AppEntities.Identity;
using Microsoft.AspNetCore.Identity;

namespace ATTicket.Application.Features.AppFeatures.AuthFeatures.Commands.CreateUser;
public sealed class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, CreateUserCommandResponse>
{
    private readonly IAuthService _authService;
    private readonly UserManager<AppUser> _userManager;

    public CreateUserCommandHandler(IAuthService authService, UserManager<AppUser> userManager)
    {
        _authService = authService;
        _userManager = userManager;
    }

    public async Task<CreateUserCommandResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        AppUser user = await _authService.GetByEmailOrUserNameAsync(request.UserName);
        if (user != null) throw new Exception("Kullanıcı Adı Zaten Var!");
        AppUser user2 = await _authService.GetByEmailOrUserNameAsync(request.Email);

        if (user2 != null) throw new Exception("Kullanıcı Email Zaten Var!");
        _userManager.CreateAsync(new AppUser
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            RefreshToken = Guid.NewGuid().ToString(),
            UserName = request.UserName,
            Email = request.Email,
            Id = Guid.NewGuid().ToString(),
            NameLastName = request.NameLastName
        }, request.Password).Wait();
        return new();
    }
}