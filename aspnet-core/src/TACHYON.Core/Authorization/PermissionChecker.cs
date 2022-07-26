using Abp.Authorization;
using TACHYON.Authorization.Roles;
using TACHYON.Authorization.Users;

namespace TACHYON.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
