using ATTicket.Application.Messaging;
namespace ATTicket.Application.Features.AppFeatures.AuthFeatures.Commands.Login;
public sealed record LoginCommand(string EmailOrUserName, string Password) : ICommand<LoginCommandResponse>;