namespace ATTicket.Application.Features.CompanyFeatures.TicketSolution.Commands.Create;
public sealed record CreateTicketSolutionCommand
                (
                    string TicketId,
                    string Solution,
                    string TicketDefinition,
                    string TicketLabels
                ) :ICommand<CreateTicketSolutionCommandResponse>;
