namespace ATTicket.Application.Features.CompanyFeatures.TicketLine.Commands.Create;
public sealed record CreateTicketLineCommand
                      (
                        int TicketId,
                        string AssignedTo,
                        string Assistant,
                        string LineType,
                        int LineState,
                        string LineMessage,
                        string Note,
                        long Duration,
                        bool Closed):ICommand<CreateTicketLineCommandResponse>;
