using ATTicket.Application.Features.CompanyFeatures.ViewClient.Commands.Create;

namespace ATTicket.Application.Services.CompanyServices
{
    public interface IViewClientService
    {
        Task<IList<ViewClient>> GetAllAsync(string companyId);
        Task<ViewClient> GetByIdAsync(string id, string companyId);
        Task<ViewClient> CreateViewClientAsync(CreateViewClientCommand request, CancellationToken cancellationToken);
        Task<ViewClient> RemoveByIdViewClientAsync(string id, string companyId);
        Task UpdateAsync(ViewClient viewClient, string companyId);
    }
}