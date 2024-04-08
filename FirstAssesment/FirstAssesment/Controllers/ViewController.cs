using FirstAssesment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Security.Cryptography;

using static System.Net.Mime.MediaTypeNames;

namespace FirstAssesment.Controllers
{
    public class ViewController : Controller
    {
        private readonly ShopContext _context;

        public ViewController(ShopContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Customer()
        {
            var result = _context.Customers.ToList();
            return View(result);
        }
        public IActionResult Register(Customer model)
        {
            if (ModelState.IsValid)
            {
                var user = new Customer()
                {
                    Username = model.Username,
                    Email = model.Email,
                    Contact = model.Contact,
                    Password = model.Password,
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

            var user = _context.Customers.FirstOrDefault(u => u.Username == username);
            if (user != null && password == user.Password)
            {
                return RedirectToAction("Index");
            }
            else
            {

                return RedirectToAction("Login");
            }
        }
        public IActionResult Account()
        {
            return View();
        }

        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(Category model, IFormFile imagedatas)
        {
            if (imagedatas != null && imagedatas.Length > 0)
            {
                using (MemoryStream str = new MemoryStream())
                {
                    imagedatas.CopyTo(str);
                    model.image = str.ToArray();
                }

            }
            _context.Categories.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Data()
        {
            var result = _context.Categories.ToList();
            return new JsonResult(result);
        }

        public IActionResult GetData()
        {
            return View();
        }
        public IActionResult Silver()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Silver(SubCategory model, IFormFile imagedatas)
        {
            if (imagedatas != null && imagedatas.Length > 0)
            {
                using (MemoryStream str = new MemoryStream())
                {
                    imagedatas.CopyTo(str);
                    model.Image = str.ToArray();
                }

            }
            _context.SubCategories.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Get()
        {
            var result = _context.SubCategories.ToList();
            return new JsonResult(result);

        }
        public IActionResult GetSilver()
        {
            return View();
        }
        public IActionResult AddToCart()
        {
            return View();

        }
        public IActionResult Add()
        {
            var result = _context.Carts.ToList();
            return new JsonResult(result);

        }

        [HttpPost]
        public IActionResult AddToCart(int id)
        {

            var productToAdd = _context.Categories.FirstOrDefault(item => item.Id == id);

            if (productToAdd != null)
            {

                var cartItem = new Cart
                {
                    Name = productToAdd.Name,
                    price = productToAdd.price,
                    Image = productToAdd.image
                };

                _context.Carts.Add(cartItem);
                _context.SaveChanges();
                return RedirectToAction("AddToCart");
            }
            else
            {
                return View();
            }


        }
        public IActionResult Delete(int id)
        {
            var cartItem = _context.Carts.SingleOrDefault(e => e.Id == id);
            if (cartItem != null)
            {
                _context.Carts.Remove(cartItem);
                _context.SaveChanges();
            }

            return Json(new { success = true });
        }

        public IActionResult Cart(int id)
        {
            var silver = _context.SubCategories.FirstOrDefault(x => x.Id == id);


            if (silver != null)
            {

                var cartItem = new Cart
                {
                    Name = silver.Name,
                    price = silver.price,
                    Image = silver.Image
                };

                _context.Carts.Add(cartItem);
                _context.SaveChanges();
                return RedirectToAction("AddToCart");
            }
            else
            {
                return View();
            }


        }
        public IActionResult Bill()
        {
            var cartDetails = _context.Carts.ToList();
            var total = cartDetails.Sum(item => item.price);
            ViewBag.TotalPrice = total;
            ClearCart();
            return View(cartDetails);
        }
       
        private void ClearCart()
        {
            var cartItems = _context.Carts.ToList();

            if (cartItems.Any())
            {
                _context.Carts.RemoveRange(cartItems);
                _context.SaveChanges();
            }

        }
    }
}


