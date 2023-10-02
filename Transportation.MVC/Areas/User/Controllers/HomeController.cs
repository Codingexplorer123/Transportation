using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Transportation.MVC.Models;

namespace Transportation.MVC.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        public async Task<IActionResult> Index()
        {
           
            return View();
        }
    }
}
