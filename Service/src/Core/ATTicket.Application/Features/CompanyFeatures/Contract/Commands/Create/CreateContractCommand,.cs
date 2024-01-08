namespace ATTicket.Application.Features.CompanyFeatures.Contract.Commands.Create;
public sealed record CreateContractCommand
             (string? ContractNo,
              int? ContractType,
              string? Definition,
              DateTime? BegDate,
              DateTime? EndDate,
              string? Explanation,
              double? Amount,
              string? Currency,
              string? OrderNr,
              string companyId,
              string? CreatedUser) : ICommand<CreateContractCommandResponse>;
