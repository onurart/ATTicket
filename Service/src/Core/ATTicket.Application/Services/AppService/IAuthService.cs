using ATTicket.Domain.AppEntities;
using ATTicket.Domain.AppEntities.Identity;

namespace ATTicket.Application.Services.AppService
{
    public interface IAuthService
    {
        Task<AppUser> GetByEmailOrUserNameAsync(string emailOrUserName);
        Task<bool> CheckPasswordAsync(AppUser user, string password);
        Task<AppUser> ChangePasswordAsync(AppUser user, string currentPassword, string newPassword);
        Task<IList<UserAndCompanyRelationship>> GetCompanyListByUserIdAsync(string userId);
        Task<string> GetMainRolesByUserId(string userId);
    }
}
