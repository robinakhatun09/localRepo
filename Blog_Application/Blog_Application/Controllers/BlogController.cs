using Blog_Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blog_Application.Controllers
{
    public class BlogController : Controller
    {
        public readonly BlogContext _context;
        public BlogController(BlogContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetData()
        {
            var result = _context.BlogPost.ToList();
            return Json(result);
        }
        public IActionResult Create(BlogPosts model)
        {

            var blog = new BlogPosts()
            {
                Id = model.Id,
                Title = model.Title,
                Content = model.Content,
                DateCreated = DateTime.UtcNow,
                DateModified = DateTime.UtcNow,

            };
            _context.BlogPost.Add(blog);
            _context.SaveChanges();
            return Json(blog);


        }
        public IActionResult Edit(BlogPosts blog)
        {


            _context.BlogPost.Update(blog);
            _context.SaveChanges();
            return Json(blog);

        }
        public IActionResult Delete(int id)
        {
            var ur = _context.BlogPost.Find(id);
            if (ur != null)
            {
                _context.BlogPost.Remove(ur);
                _context.SaveChanges();
                return new JsonResult("Ok");
            }
            return RedirectToAction("Index");

        }

    }
}
