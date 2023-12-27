using ATTicket.Application.Messaging;
namespace ATTicket.Application.Features.AppFeatures.UserRoleFeatures.Commands.CreateUserRole;
public sealed record CreateUserRoleCommand(string RoleId, string UserId) : ICommand<CreateUserRoleCommandResponse>;