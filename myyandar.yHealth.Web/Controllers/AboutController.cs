using System.Web.Mvc;

namespace myyandar.yHealth.Web.Controllers
{
    public class AboutController : yHealthControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}