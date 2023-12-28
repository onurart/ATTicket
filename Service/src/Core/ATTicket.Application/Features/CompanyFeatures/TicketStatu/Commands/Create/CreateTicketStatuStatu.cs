namespace ATTicket.Application.Features.CompanyFeatures.TicketStatu.Commands.Create;
public sealed record CreateTicketStatuStatu
    (
    
    string MainStatu,
    string Statu) :ICommand<CreateTicketStatuStatuResponse>;