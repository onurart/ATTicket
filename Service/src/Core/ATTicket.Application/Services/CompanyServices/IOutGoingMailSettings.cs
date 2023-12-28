using ATTicket.Application.Features.CompanyFeatures.OutGoingMailSettings.Commands.Create;

namespace ATTicket.Application.Services.CompanyServices
{
    public interface IOutGoingMailSettings
    {
        Task<IList<OutGoingMailSettingses>> GetAllAsync(string companyId);
        Task<OutGoingMailSettingses> GetByIdAsync(string id, string companyId);
        Task<OutGoingMailSettingses> CreateOutGoingMailSettingAsync(CreateOutGoingMailSettingCommand request, CancellationToken cancellationToken);
        Task<OutGoingMailSettingses> RemoveByIdOutGoingMailSettingsAsync(string id, string companyId);
        Task UpdateAsync(OutGoingMailSettingses outGoingMailSettingses, string companyId);
    }
}
