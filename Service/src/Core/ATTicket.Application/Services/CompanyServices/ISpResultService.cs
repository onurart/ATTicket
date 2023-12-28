using ATTicket.Application.Features.CompanyFeatures.SpResult.Commands.Create;

namespace ATTicket.Application.Services.CompanyServices
{
    public interface ISpResultService
    {
        Task<IList<SpResult>> GetAllAsync(string companyId);
        Task<SpResult> GetByIdAsync(string id, string companyId);
        Task<SpResult> CreateSpResultAsync(CreateSpResultCommand request, CancellationToken cancellationToken);
        Task<SpResult> RemoveByIdSpResultAsync(string id, string companyId);
        Task UpdateAsync(SpResult spResult, string companyId);
    }
}
