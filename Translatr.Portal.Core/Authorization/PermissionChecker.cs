using Abp.Authorization;
using Translatr.Portal.Authorization.Roles;
using Translatr.Portal.MultiTenancy;
using Translatr.Portal.Users;

namespace Translatr.Portal.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
