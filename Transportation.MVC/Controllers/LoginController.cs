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
            ,SignInManager<MyUser> signInManager)
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
        [AllowAnonymous]
        public async Task<IActionResult> Index(LoginDTO loginDTO)
        {
            if(!ModelState.IsValid)
            {
                return View(loginDTO);
            }
            // burada modelstate.IsValid methodu ile model icerisinde belirttigimiz tum logindto annotationlarina girilen ifade uygunmu kontrol eder.
            var user2=await  userManager.FindByEmailAsync(loginDTO.Email);

            var roles =await  userManager.GetRolesAsync(user2);

            var result = await signInManager.PasswordSignInAsync(user2, loginDTO.Password, (bool)loginDTO.RememberMe, true);
            
            //var user = userManager.GetAllInclude(u=>u.Email==loginDTO.Email && u.Password == loginDTO.Password).ToString();
            // user tarafindan girilen veriler ile databasedeki veriler kontrol edilir


            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Email yada sifre hatalidir");
                return View(loginDTO);
            }
            foreach (var role in roles)
            {
                if(role=="Admin")
                    return RedirectToAction("Index", "Nakliye", new { Area =role});

            }

            return RedirectToAction("Index","Home");
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
	}
}
