using Microsoft.AspNetCore.Mvc;
using Transportation.Business.Abstract;
using Transportation.MVC.Models.DTOs;

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
            LoginDTO loginDTO = new LoginDTO();
            return View(loginDTO);
        }
    }
}
