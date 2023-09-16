﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Security.Claims;
using Transportation.Business.Abstract;
using Transportation.MVC.Models.DTOs;

namespace Transportation.MVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserManager userManager;
        private readonly IRoleManager roleManager;

        public LoginController(IUserManager userManager, IRoleManager roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;

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

            var user = userManager.GetAllInclude(u=>u.Email==loginDTO.Email && u.Password == loginDTO.Password).ToString();
            // user tarafindan girilen veriler ile databasedeki veriler kontrol edilir

            if(user==null)
            {
                ModelState.AddModelError("", "Kullanici Adi Yada Sifre Hatali");
                return View(loginDTO);
            }
           
            return RedirectToAction("Index","Nakliye");
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
