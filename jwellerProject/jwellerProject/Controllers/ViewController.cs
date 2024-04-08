using jwellerProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace jwellerProject.Controllers
{
    public class ViewController : Controller
    {
      
            private readonly ShopJwelleryContext _context;

            public ViewController(ShopJwelleryContext context)
            {
                _context = context;
            }

            public IActionResult Index()
            {
               return View();
            }
        public IActionResult Ragister()
        {
            return View();
        }
        public IActionResult Customer()
            {
            var result = _context.Customers.ToList();
            return View(result);
            }
        [HttpPost]
            public IActionResult Ragister(Customer model)
            {
            if (ModelState.IsValid)
            {
                var user = new Customer()
                {
                    Username = model.Username,
                    Email = model.Email,
                    Contact = model.Contact,
                    password = model.password,
                    ConfirmPassword = model.ConfirmPassword
                };
                _context.Customers.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            else
            {
                return View(model);
            }

            }
           public IActionResult Login()
           {
            return View();
           }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                TempData["ErrorMessage"] = "Username and password are required.";
                return RedirectToAction("Login");
            }

            var user = _context.Customers.FirstOrDefault(u => u.Username == username);
            if (user != null && password == user.password)
            {
                return RedirectToAction("Index");
            }
            else
            {
                TempData["ErrorMessage"] = "Invalid username or password.";
                return RedirectToAction("Login");
            }
        }
        public IActionResult GetData()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult GetData(SubCategory model, IFormFile image)
        {
            if (image != null && image.Length > 0)
            {
                using (MemoryStream str = new MemoryStream())
                {
                    image.CopyTo(str);
                    model.Image = str.ToArray();
                }

            }
            _context.SubCategories.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Data()
        {
            var result = _context.SubCategories.ToList();
            return new JsonResult(result);
        }
       public IActionResult AddToCart()
        {
            return View();
        }

    }
}
