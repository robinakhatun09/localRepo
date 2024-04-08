using CascadingProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CascadingProject.Controllers
{
    
    public class CascadingDataController : Controller
    {
        private readonly CascadingContext _context;

        public CascadingDataController(CascadingContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CountryData()
        {
            var countries = _context.Countries.ToList();
            return Json(countries);
        }

        public IActionResult StateData(int id)
        {

            var states = _context.States.Where(e => e.Country.Id == id).ToList();
           
            return Json(states);
        }

        public IActionResult CityData(int id)
        {
            var cities = _context.Cities.Where(e => e.State.Id == id).ToList();
            return Json(cities);
        }

    }
}
