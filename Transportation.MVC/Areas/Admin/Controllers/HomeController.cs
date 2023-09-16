using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Transportation.Business.Abstract;

namespace Transportation.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    
    public class HomeController : Controller
    {
        private readonly INakliyeManager _nakliyeManager;

        public HomeController(INakliyeManager nakliyeManager)
        {
            _nakliyeManager = nakliyeManager;
        }
        public async Task<IActionResult> Index()
        {
            var nakliyeler = await _nakliyeManager.GetAllAsync();
            return View(nakliyeler);
        }
    }
}
