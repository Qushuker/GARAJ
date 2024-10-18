using Abp.Authorization;
using GARAJ.Authorization.Roles;
using GARAJ.Authorization.Users;

namespace GARAJ.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
