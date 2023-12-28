using System.Data;

namespace ATTicket.Application.Features.CompanyFeatures.ViewContract.Commands.Create;
public sealed record CreateViewContractCommand
                     (
                       string AppUserId,
                       string ContractNo,
                       string ClientTitle,
                       string Definition,
                       DataTable BegDate,
                       DataTable EndDate,
                       string Explanation
                        ) : ICommand<CreateViewContractCommandResponse>;
