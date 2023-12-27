using ATTicket.Application.Messaging;
namespace ATTicket.Application.Features.AppFeatures.MainRoleFeatures.Commands.UpdateMainRole;
public sealed record UpdateMainRoleCommand(string Id, string Title) : ICommand<UpdateMainRoleCommandResponse>;