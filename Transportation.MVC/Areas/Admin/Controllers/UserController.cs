using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Transportation.Business.Abstract;
using Transportation.Data.Context;
using TransportationEntity;

namespace Transportation.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "admin")]
    public class UserController : Controller
    {
        private readonly UserManager<MyUser> _userManager;
        private readonly TransportationDbContext _dbcontext;

        public UserController(UserManager<MyUser> userManager, TransportationDbContext dbContext)
        {
            _dbcontext = dbContext;
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            return View(users);
        }
        public async Task<IActionResult> GetByEmail(string? email)
        {
            if(email == null || _dbcontext.Users == null) 
            {
                return BadRequest(email);
            }
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);


        }
        

    }
}
