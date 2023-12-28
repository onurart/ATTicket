namespace ATTicket.Application.Features.CompanyFeatures.ContractLine.Commands.Create;

public sealed record CreateContactLineCommand
                     (int? LineNr,
                      string? InvoiceNr,
                      double? Amout,
                      string? LineExplanation):ICommand<CreateContactLineCommandResponse>;

