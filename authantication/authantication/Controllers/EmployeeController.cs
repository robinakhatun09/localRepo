using Microsoft.AspNetCore.Mvc;

namespace authantication.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
