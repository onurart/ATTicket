namespace ATTicket.Application.Features.CompanyFeatures.Rl_UserClient.Commands.Create;
public sealed record CreateRlUserClientCommand(string AppUserId,int Priority) :ICommand<CreateCreateRlUserClientCommandResponse>;
