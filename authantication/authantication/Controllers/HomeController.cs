using authantication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace authantication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Login()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = "Ruby@gmail.com";
            var pass = "ruby12";
            var e = "rubina061ansari@gmail.com";
            var p = "rubina123";

            if (username == user && password == pass)
            {
                TempData["Roles"] = "admin";

                return RedirectToAction("Index");
            }
            else if (username == e && password == p)
            {
                TempData["Roles"] = "employee";
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid username or password");
                return View();
            }
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Task()
        {
            return View();
        }
        public IActionResult AddEmployee()

        {
            return View();
        }

        public IActionResult Employeelist()
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
