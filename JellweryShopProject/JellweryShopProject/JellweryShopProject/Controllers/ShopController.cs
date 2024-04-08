using Microsoft.AspNetCore.Mvc;

namespace JellweryShopProject.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
