using ATTicket.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;
using ATTicket.Application.Messaging;
namespace ATTicket.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateRole;
public sealed record CreateMainRoleCommand(string Title) : ICommand<CreateMainRoleCommandResponse>;