﻿using Microsoft.AspNetCore.Authorization;
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

            var result = await signInManager.PasswordSignInAsync(user2, loginDTO.Password, true, false);

            
            var roleName = "admin";
            var roleName2 = "user";
            var roleAdminMi = await roleManager.RoleExistsAsync(roleName);
            var roleUserMi = await roleManager.RoleExistsAsync(roleName2);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Email yada sifre hatalidir");
                return View(loginDTO);
            }
            if(roleAdminMi)
            {
              return RedirectToAction("Index", "Home", new { Area = "Admin" });


            }

            if (roleUserMi)
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
        public async Task<IActionResult> Logout()
        {
            return View();
        }
    }
}
