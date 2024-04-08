using entity.Models;
using Microsoft.AspNetCore.Mvc;

namespace entity.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly firstDbContext context;

        public EmployeeController(firstDbContext context)
        {
            this.context = context;
        }
        public IActionResult index()
        {
            
            return View();
        }
    }
}
