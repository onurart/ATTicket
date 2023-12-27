using ATTicket.Application.Messaging;
namespace ATTicket.Application.Features.AppFeatures.MainRoleFeatures.Commands.RemoveMainRole;
public sealed record RemoveByIdMainRoleCommand(string Id) : ICommand<RemoveByIdMainRoleCommandResponse>;