using ATTicket.Application.Messaging;
using ATTicket.Domain.AppEntities;
namespace ATTicket.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRoles;
public sealed record CreateStaticMainRolesCommand(List<MainRole> MainRoles) : ICommand<CreateStaticMainRolesCommandResponse>;