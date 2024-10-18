using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace GARAJ.Controllers
{
    public abstract class GARAJControllerBase: AbpController
    {
        protected GARAJControllerBase()
        {
            LocalizationSourceName = GARAJConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
