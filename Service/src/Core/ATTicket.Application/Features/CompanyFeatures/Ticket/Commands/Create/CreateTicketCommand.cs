namespace ATTicket.Application.Features.CompanyFeatures.Ticket.Commands.Create;
public sealed record CreateTicketCommand
                     (
                      string TicketNr,
                      string ActionUrl,
                      string TicketTitle,
                      string AssignedTo,
                      string Asistant,
                      int TicketType,
                      int ServiceType,
                      string TicketState,
                      string AppUserId,
                      int Contract,
                      int DepartmentId,
                      string ClientEmail,
                      string ClientPhone,
                      int ProductId,
                      int Module,
                      double Price,
                      double Kdv,
                      double Total,
                      string TicketTypeExplanation,
                      string companyId) : ICommand<CreateTicketCommandResponse>;

