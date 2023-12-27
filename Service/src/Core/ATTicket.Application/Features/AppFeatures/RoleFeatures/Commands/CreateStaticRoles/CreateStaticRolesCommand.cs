using ATTicket.Application.Messaging;
namespace ATTicket.Application.Features.AppFeatures.RoleFeatures.Commands.CreateAllRoles;
public sealed record CreateStaticRolesCommand() : ICommand<CreateStaticRolesCommandResponse>;