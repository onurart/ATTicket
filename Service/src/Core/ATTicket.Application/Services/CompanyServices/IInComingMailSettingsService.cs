using ATTicket.Application.Features.CompanyFeatures.InComingMailSettings.Commands.Create;

namespace ATTicket.Application.Services.CompanyServices
{
    public interface IInComingMailSettingsService
    {
        Task<IList<InComingMailSettings>> GetAllAsync(string companyId);
        Task<InComingMailSettings> GetByIdAsync(string id, string companyId);
        Task<InComingMailSettings> CreateInComingMailSettingsAsync(CreateInComingMailSettingCommand request, CancellationToken cancellationToken);
        Task<InComingMailSettings> RemoveByIdInComingMailSettingsAsync(string id, string companyId);
        Task UpdateAsync(InComingMailSettings inComingMailSettings, string companyId);
    }
}
