namespace ATTicket.Application.Features.CompanyFeatures.InComingMailSettings.Commands.Create;
public sealed record CreateInComingMailSettingCommand
                      (
                        string HostName,
                        int Port,
                        string Email,
                        string Password,
                        string EmailAddressTo,
                        string ExcluedEmailAddressFrom,
                        string IncluedEmailAddressFrom,
                        string companyId) : ICommand<CreateInComingMailSettingCommandRes>;