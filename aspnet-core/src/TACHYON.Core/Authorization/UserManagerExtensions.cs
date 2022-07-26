using System.Threading.Tasks;
using Abp.Authorization.Users;
using TACHYON.Authorization.Users;

namespace TACHYON.Authorization
{
    public static class UserManagerExtensions
    {
        public static async Task<User> GetAdminAsync(this UserManager userManager)
        {
            return await userManager.FindByNameAsync(AbpUserBase.AdminUserName);
        }
    }
}
