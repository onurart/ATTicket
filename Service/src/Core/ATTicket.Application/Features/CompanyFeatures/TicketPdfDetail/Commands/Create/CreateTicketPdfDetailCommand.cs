namespace ATTicket.Application.Features.CompanyFeatures.TicketPdfDetail.Commands.Create;
public sealed record CreateTicketPdfDetailCommand
    (
        string TicketNr,
        string PersonelName,
        string TicketType,
        string ContractNo,
        string ClientTitle,
        string ClientName,
        string Definition,
        string WorkDefinition,
        string Note,
        string Price,
        string VatAmount,
        string Total,
        string Kdv
    ) : ICommand<CreateTicketPdfDetailCommandResponse>;
