using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Transportation.Business.Abstract;

namespace Transportation.MVC.Areas.Admin.ViewComponents
{
    public class AdminMenuViewComponent :ViewComponent
    {
        private readonly IMenuManager menuManager;

        public AdminMenuViewComponent(IMenuManager menuManager)
        {
            this.menuManager = menuManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var userRole = HttpContext.User.FindFirstValue(ClaimTypes.Role);
           

            var result = menuManager.GetAllInclude(p=>p.Role.Name== userRole, p=>p.Role).Result.ToList();

            return View(result);
        }
    }
}
