namespace ATTicket.Application.Features.CompanyFeatures.TicketList.Commands.Create;
public sealed record CreateTicketListCommand
                     (
                        string TicketNr,
                        string TicketTitle,
                        string AppUserId,
                        string TicketState,
                        string ClientName,
                        string ProductName,
                        string TicketType
                        ):ICommand<CreateTicketListCommandResponse>;