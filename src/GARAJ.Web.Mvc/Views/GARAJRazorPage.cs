using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace GARAJ.Web.Views
{
    public abstract class GARAJRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected GARAJRazorPage()
        {
            LocalizationSourceName = GARAJConsts.LocalizationSourceName;
        }
    }
}
