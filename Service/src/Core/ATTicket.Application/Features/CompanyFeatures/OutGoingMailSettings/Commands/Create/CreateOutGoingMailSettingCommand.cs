namespace ATTicket.Application.Features.CompanyFeatures.OutGoingMailSettings.Commands.Create;
public sealed record class CreateOutGoingMailSettingCommand
                (
                  string HostName,
                  int Port,
                  string Email,
                  string Password,
                  string companyId) :ICommand<CreateOutGoingMailSettingCommandResponse>;
