using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using GARAJ.Controllers;

namespace GARAJ.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : GARAJControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
