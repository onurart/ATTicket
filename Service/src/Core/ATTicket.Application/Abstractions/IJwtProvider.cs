using ATTicket.Domain.AppEntites.Identity;
using ATTicket.Domain.Dtos;
namespace ATTicket.Application.Abstractions;
internal interface IJwtProvider
{
    Task<TokenRefreshTokenDto> CreateTokenAsync(AppUser user);

}
