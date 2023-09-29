using Microsoft.AspNetCore.Mvc;

namespace Transportation.MVC.Areas.Admin.Controllers
{
    public class AracController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
