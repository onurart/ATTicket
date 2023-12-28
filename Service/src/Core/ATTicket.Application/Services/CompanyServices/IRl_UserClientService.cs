using ATTicket.Application.Features.CompanyFeatures.Rl_UserClient.Commands.Create;

namespace ATTicket.Application.Services.CompanyServices;
public  interface IRl_UserClientService
{
    Task<IList<Rl_UserClient>> GetAllAsync(string companyId);
    Task<Rl_UserClient> GetByIdAsync(string id, string companyId);
    Task<Rl_UserClient> CreateRl_UserClientAsync(CreateRlUserClientCommand request, CancellationToken cancellationToken);
    Task<Rl_UserClient> RemoveByIdRl_UserClientAsync(string id, string companyId);
    Task UpdateAsync(Rl_UserClient rl_UserClient, string companyId);
}
