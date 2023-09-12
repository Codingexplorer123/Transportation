using Microsoft.AspNetCore.Mvc;
using Transportation.Business.Abstract;

namespace Transportation.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IUserManager _userManager;

        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var users = await _userManager.GetAllAsync();
            return View(users);
        }
        

    }
}
