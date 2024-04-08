using Microsoft.AspNetCore.Mvc;

namespace ragistrationformMVC.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
