using Abp.AspNetCore.Mvc.ViewComponents;

namespace GARAJ.Web.Views
{
    public abstract class GARAJViewComponent : AbpViewComponent
    {
        protected GARAJViewComponent()
        {
            LocalizationSourceName = GARAJConsts.LocalizationSourceName;
        }
    }
}
