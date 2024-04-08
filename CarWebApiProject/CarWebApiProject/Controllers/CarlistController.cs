using CarWebApiProject.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace CarWebApiProject.Controllers
{
    [Route("Api/[Controller]")]
    [ApiController]
    public class CarlistController : ControllerBase
    {
        private readonly CarContext _context;

        public CarlistController(CarContext context)
        {
            _context = context;
        }

        // For Getting All The data Present in database

        [HttpGet]
        public IActionResult GetCar()
        {
            return new JsonResult(_context.Cars.ToList());
        }

        //For Getting Bike By Id

        [HttpGet("{id}")]

        public IActionResult GetCar(int id)
        {
            var car = _context.Cars.Find(id);
            return new JsonResult(car);
        }

        //For Updating Data By Id

        [HttpPut("{id}")]

        public IActionResult PutCar(int id, Car car)
        {
            _context.Cars.Update(car);
            _context.SaveChanges();
            return new JsonResult("Successfully Updated");
        }
    

        //For Delete Data By Id

        [HttpDelete("{id}")]

        public IActionResult DeleteCar(int id)
        {
            var RemoveCar = _context.Cars.Find(id);
            _context.Remove(RemoveCar);
            _context.SaveChanges();
            return new JsonResult("Deleted Successfully");
        }

        //For Create Data 

        [HttpPost]

        public IActionResult PostCar(Car car)
        {
            _context.Add(car);
            _context.SaveChanges();
            return new JsonResult("Created Successfully");

        }


    }
}

