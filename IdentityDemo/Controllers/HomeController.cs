using IdentityDemo.Data;
using IdentityDemo.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IdentityDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger, UserManager<Member> userManager,
            ApplicationDbContext db, RoleManager<IdentityRole>role;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult>/*IActionResult*/ Index()
        {
            //var res = DBNull.Users.Where(m => m.IsPro).ToList();

            //foreach (var m in res)
            //{

            //}
            var user = await userManager.AddToRoleAsync
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}