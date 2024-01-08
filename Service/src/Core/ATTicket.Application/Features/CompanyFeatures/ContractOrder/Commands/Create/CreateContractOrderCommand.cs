namespace ATTicket.Application.Features.CompanyFeatures.ContractOrder.Commands.Create
{
    public sealed record CreateContractOrderCommand
                         (string? OrderNo,
                          string? Docode,
                          DateTime? OrderDate,
                          double? OrderTotal,
                          double TotalVat,
                          double GrossTotal,
                          double LineNet,
                          string? InvoiceNo,
                          string? Currency,
                          string? companyId) : ICommand<CreateContractOrderResponse>;
}
