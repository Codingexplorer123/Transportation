using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Index(LoginDTO loginDTO)
        {
            if(!ModelState.IsValid)
            {
                return View(loginDTO);
            }
            // burada modelstate.IsValid methodu ile model icerisinde belirttigimiz tum logindto annotationlarina girilen ifade uygunmu kontrol eder.

            var user = userManager.GetAllAsync(u=>u.Email==loginDTO.Email && u.Password == loginDTO.Password).Result.FirstOrDefault();
            // user tarafindan girilen veriler ile databasedeki veriler kontrol edilir

            if(user==null)
            {
                ModelState.AddModelError("", "Kullanici Adi Yada Sifre Hatali");
                return View(loginDTO);
            }

        }
    }
}
