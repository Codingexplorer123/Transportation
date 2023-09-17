using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Transportation.Business.Abstract;

namespace Transportation.MVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles ="admin")]
    public class MenuController : Controller
    {
        private readonly IMenuManager menuManager;

        public MenuController(IMenuManager menuManager)
        {
            this.menuManager = menuManager;
        }
        public async  Task<IActionResult> Index()
        {

            var result = await menuManager.GetAllInclude(null,p=>p.Role);
            return View(result);
        }
    }
}
