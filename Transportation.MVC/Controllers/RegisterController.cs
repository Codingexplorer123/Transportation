using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Transportation.MVC.Models.DTOs;
using TransportationEntity;

namespace Transportation.MVC.Controllers
{
	public class RegisterController : Controller
	{
        private readonly UserManager<MyUser> userManager;
        private readonly IMapper mapper;

        public RegisterController(UserManager<MyUser> userManager,IMapper mapper)
        {
            this.userManager = userManager;
            this.mapper = mapper;
        }
        public IActionResult Index()
		{
			var register = new RegisterDTO();
			return View(register);
		}

		[HttpPost]
		public async Task<IActionResult> Register(RegisterDTO register)
		{
			MyUser user = mapper.Map<MyUser>(register);
			var result = await userManager.CreateAsync(user, register.Password);

			if(result.Succeeded)
			{
				await userManager.AddToRoleAsync(user, "Admin");
				return RedirectToAction("Index", "Home", new { Area = "Admin" });
			}
			else
			{
				ModelState.AddModelError("", "Hata oldu");
				return View(register);
			}
			

		}
	}
}
