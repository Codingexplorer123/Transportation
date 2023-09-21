using Microsoft.AspNetCore.Mvc;

namespace Transportation.MVC.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
           
            return View();
        }
    }
}
