﻿using AutoMapper;
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
		private readonly RoleManager<IdentityRole> rolemanager;

		public RegisterController(UserManager<MyUser> userManager,IMapper mapper,RoleManager<IdentityRole> rolemanager)
        {
            this.userManager = userManager;
            this.mapper = mapper;
			this.rolemanager = rolemanager;
		}
        public IActionResult Register()
		{
			var register = new RegisterDTO();
			return View(register);
		}

		[HttpPost]
		public async Task<IActionResult> Register(RegisterDTO register)
		{
			
			
			MyUser user = mapper.Map<MyUser>(register);

			// AutoMapper calismadigi icin malesef asagidaki verileri manual olarak aktardim..
			user.UserName = register.UserName;
			user.Email = register.Email;
			user.TCNo = 12345678912;


			var result = await userManager.CreateAsync(user, register.Password);

			
			if(result.Succeeded)
			{
				var role = new IdentityRole();
				role.Name = "User";
				await rolemanager.CreateAsync(role);
				await userManager.AddToRoleAsync(user, "User");
				return RedirectToAction("GetTumTalepler", "Nakliye");
			}
			else
			{
				ModelState.AddModelError("", "Hata oldu");
				return View(register);
			}
			

		}
	}
}
