using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace myyandar.yHealth.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : yHealthControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}