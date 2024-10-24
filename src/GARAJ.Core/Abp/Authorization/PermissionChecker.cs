using Abp.Authorization;
using GARAJ.Abp.Authorization.Roles;
using GARAJ.Abp.Authorization.Users;

namespace GARAJ.Abp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
