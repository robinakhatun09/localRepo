using demo_page.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace demo_page.Controllers
{
    public class DemoController : Controller
    {
        public readonly DemoContext _context;
        public DemoController(DemoContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Demos.ToList();
            return View(data);
        }
       
        public IActionResult DemoView()
        {
            var data = _context.Demos.ToList();
            return View(data);
        }
    }
}
