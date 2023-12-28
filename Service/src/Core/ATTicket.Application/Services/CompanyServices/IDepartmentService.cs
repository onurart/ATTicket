using ATTicket.Application.Features.CompanyFeatures.Department.Commands.Create;

namespace ATTicket.Application.Services.CompanyServices;
public interface IDepartmentService
{
    Task<IList<Departments>> GetAllAsync(string companyId);
    Task<Departments> GetByIdAsync(string id, string companyId);
    Task<Departments> CreateDepartmentAsync(CreateDepartmentCommand request, CancellationToken cancellationToken);
    Task<Departments> RemoveByIdDepartmentAsync(string id, string companyId);
    Task UpdateAsync(Departments departments, string companyId);
}
