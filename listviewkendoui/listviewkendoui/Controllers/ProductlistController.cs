using listviewkendoui.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace listviewkendoui.Controllers
{
    public class ProductlistController : Controller
    {
        private readonly Productcontext _context;

        public ProductlistController(Productcontext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var result = _context.BeautyProducts.ToList();
            return View(result);
           
        }
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(BeautyProduct model, IFormFile imagedatas)
        {
            if (imagedatas != null && imagedatas.Length > 0)
            {
                using (MemoryStream str = new MemoryStream())
                {
                    imagedatas.CopyTo(str);
                    model.Image = str.ToArray();

                }

            }
            _context.BeautyProducts.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        //public IActionResult Edit(Traveler trv)
        //{

        //    _context.Travelers.Update(trv);
        //    _context.SaveChanges();
        //    //return new JsonResult(trv);


        //}

        public IActionResult Delete(int Id)
        {
            var pr = _context.BeautyProducts.Find(Id);
            _context.BeautyProducts.Remove(pr);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}
