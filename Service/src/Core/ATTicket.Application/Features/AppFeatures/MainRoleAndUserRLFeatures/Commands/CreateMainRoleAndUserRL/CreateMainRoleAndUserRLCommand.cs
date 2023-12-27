using ATTicket.Application.Messaging;
namespace ATTicket.Application.Features.AppFeatures.MainRoleAndUserRLFeatures.Commands.CreateMainRoleAndUserRL;
public sealed record CreateMainRoleAndUserRLCommand(string UserId, string MainRoleId) : ICommand<CreateMainRoleAndUserRLCommandResponse>;