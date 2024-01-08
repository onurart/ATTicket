namespace ATTicket.Application.Features.CompanyFeatures.Product.Commands.Create;
public sealed record CreateProductCommand(string? ProductName,string companyId) :ICommand<CreateProductCommandResponse>;
