using Microsoft.AspNetCore.Mvc;
using Transportation.Business.Abstract;

namespace Transportation.MVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserManager userManager;

        public LoginController(IUserManager userManager)
        {
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
