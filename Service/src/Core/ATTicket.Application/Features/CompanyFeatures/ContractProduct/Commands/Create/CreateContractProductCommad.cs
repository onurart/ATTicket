namespace ATTicket.Application.Features.CompanyFeatures.ContractProduct.Commands.Create;
public sealed record CreateContractProductCommad
                     (
                        string? AppUserId,
                        DateTime? OrderDate,
                        string? ProductId,
                        int? ProductUserAmount,
                        int? FirmAmount,
                        string Explanation,
                        string companyId) : ICommand<CreateContractProductCommadResponse>;
