namespace ATTicket.Application.Abstractions;
public interface IJwtProvider
{
    Task<TokenRefreshTokenDto> CreateTokenAsync(AppUser user);

}
