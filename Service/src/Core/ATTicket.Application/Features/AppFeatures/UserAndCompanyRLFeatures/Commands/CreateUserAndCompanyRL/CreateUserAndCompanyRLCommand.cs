using ATTicket.Application.Messaging;
namespace ATTicket.Application.Features.AppFeatures.UserAndCompanyRLFeatures.Commands.CreateUserAndCompanyRL;
public sealed record CreateUserAndCompanyRLCommand(string AppUserId, string CompanyId) : ICommand<CreateUserAndCompanyRLCommandResponse>;