using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Security.Claims;
using Transportation.Business.Abstract;
using Transportation.MVC.Models.DTOs;
using TransportationEntity;

namespace Transportation.MVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<MyUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly SignInManager<MyUser> signInManager;

        public LoginController(UserManager<MyUser> userManager, RoleManager<IdentityRole> roleManager
            , SignInManager<MyUser> signInManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
        }
        public IActionResult Index()
        {
            LoginDTO loginDTO = new LoginDTO();
            return View(loginDTO);
            // burda loginDTO modelimizi obje olarak login(index) view icerisine gonderiyoruz
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]   // cerezlerin baska bir bilgisayar tarafindan alinip kullanilmasini engeller. Microsoft kendisi bir cerez daha atar
        [AllowAnonymous]
        public async Task<IActionResult> Index(LoginDTO loginDTO)
        {
            if (!ModelState.IsValid)
            {
                return View(loginDTO);
            }
            // burada modelstate.IsValid methodu ile model icerisinde belirttigimiz tum logindto annotationlarina girilen ifade uygunmu kontrol eder.
            var user2 = await userManager.FindByEmailAsync(loginDTO.Email);
            

            var roles = await userManager.GetRolesAsync(user2);
            // Bu userManagerdeki Metod bize girilen kullaniciya ait rolleri liste olarak getiriyor. Bizim projemizde her kullanicin bir
            // tane rolu olacagini dusunerek liste tek elemanli olarak geri donecektir. Dolayisi ile asagida roles 0 indeksdeki degerini aldim.

            
            var result = await signInManager.PasswordSignInAsync(user2, loginDTO.Password, true, false);

            
           

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Email yada sifre hatalidir");
                return View(loginDTO);
            }
            if (roles[0] == "admin")
            {
                return RedirectToAction("Index", "Home", new { Area = "Admin" });


            }

            if (roles[0] == "User")
            {
                return RedirectToAction("Index", "Home", new { Area = "User" });
            }
            return RedirectToAction("Index", "Home");
            
        }
        [HttpGet]
        public async Task<IActionResult> Forget()
        {
            return View("Forget");
        }
        [HttpPost]
        public async Task<IActionResult> Forget(string email)
        {
            if (string.IsNullOrEmpty(email) && string.IsNullOrWhiteSpace(email))
            {

            }
            return View("Forget");
        }
        public async Task<IActionResult> Exit()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
            // Guvenli cikis ile ana sayfaya yonlendiriyorum

        }
    }
}
