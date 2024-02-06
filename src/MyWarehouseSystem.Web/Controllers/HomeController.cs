using Microsoft.AspNetCore.Mvc;

namespace MyWarehouseSystem.Web.Controllers
{
    public class HomeController : MyWarehouseSystemControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}