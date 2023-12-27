using ATTicket.Application.Messaging;
namespace ATTicket.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole;
public sealed record DeleteRoleCommand(string Id) : ICommand<DeleteRoleCommandResponse>;