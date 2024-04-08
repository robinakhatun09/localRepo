using listviewTraveler.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace listviewTraveler.Controllers
{
    public class TravelerlistController : Controller
    {
        public readonly Travelercontext _context;
        public TravelerlistController(Travelercontext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View();

        } 
        public IActionResult Getdata()
        {
            var result = _context.Travelers.ToList();
            return new JsonResult(result);
        }
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(Traveler model,IFormFile imagedatas)
        {
                if (imagedatas != null && imagedatas.Length > 0)
                {
                    using (MemoryStream str = new MemoryStream())
                    {
                        imagedatas.CopyTo(str);
                        model.Image = str.ToArray();
                    }

                }
            _context.Travelers.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int Id)
        {
            var tr = _context.Travelers.SingleOrDefault(e=>e.Id == Id);
            _context.Travelers.Remove(tr);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
