using ATTicket.Application.Messaging;
namespace ATTicket.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole;
public sealed record UpdateRoleCommand(string Id, string Code, string Name) : ICommand<UpdateRoleCommandResponse>;