namespace ATTicket.Application.Features.CompanyFeatures.Department.Commands.Create;
public sealed record CreateDepartmentCommand
                     (
                     string? DepartmentName,
                     string? AppUserId,
                     string? Incharge,
                     string? Color,
                     string companyId) : ICommand<CreateDepartmentCommandReponse>;
