using Microsoft.AspNetCore.Mvc;

namespace FlightTicketBookingSystem.Controllers
{
    public class FlightBookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
