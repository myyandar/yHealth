using Abp.Authorization;
using myyandar.yHealth.Authorization.Roles;
using myyandar.yHealth.MultiTenancy;
using myyandar.yHealth.Users;

namespace myyandar.yHealth.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
