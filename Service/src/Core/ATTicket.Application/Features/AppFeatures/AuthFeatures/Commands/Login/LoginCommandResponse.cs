using ATTicket.Domain.Dtos;
namespace ATTicket.Application.Features.AppFeatures.AuthFeatures.Commands.Login;
public sealed record LoginCommandResponse(TokenRefreshTokenDto Token, string Email, string UserId, string NameLastName, string MainRole, IList<CompanyDto?>? Companies, CompanyDto? Company);