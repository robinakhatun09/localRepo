using AgGridDynamic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Cryptography.X509Certificates;

namespace AgGridDynamic.Controllers
{
    public class UserlistController : Controller
    {
        private readonly Usercontext _context;
        public UserlistController(Usercontext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var result = _context.Users.ToList();
            return View(result);
        }
        public IActionResult Create(User model)
        {
            if (ModelState.IsValid)
            {
                var user = new User()
                {

                    Name = model.Name,
                    Email = model.Email,
                    City = model.City


                };
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }

        }
        public IActionResult Edit(User ur)
        {

            _context.Users.Update(ur);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            var ur = _context.Users.Find(id);
            if (ur != null)
            {
                _context.Users.Remove(ur);
                _context.SaveChanges();
                return new JsonResult("Ok");
            }
                return RedirectToAction("Index"); 

        }


    }
}
