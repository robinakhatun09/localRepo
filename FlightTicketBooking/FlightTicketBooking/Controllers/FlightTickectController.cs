using FlightTicketBooking.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace FlightTicketBooking.Controllers
{
    public class FlightTickectController : Controller
    { 
         private readonly FlightBookingDbContext _context;
        private object flight;

        public FlightTickectController(FlightBookingDbContext context)
    {
        _context = context;
    }    
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register(Register model)
        {
            if (ModelState.IsValid)
            {
                var user = new Register()
                {
                    Username = model.Username,
                    Email = model.Email,
                    Contact = model.Contact,
                    Password = model.Password,
                    ConfirmPassword = model.ConfirmPassword
                };
                _context.Registers.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Register");
            }
            else
            {
                return View(model);
            }
        }     
        public IActionResult Login(string email, string password)
        {
            var user = _context.Registers.FirstOrDefault(u => u.Email == email) ;
            if (user != null && password == user.Password)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Register");
            }
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }     

        public IActionResult Account()
        {
            
            return View();
        }
        public IActionResult Flight()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SearchFlights(string Departure, string Arrival)
        {
            var filteredFlights = _context.Flights
                .Where(f => f.DepartureCity == Departure && f.ArrivalCity == Arrival )
                .ToList();

            return new JsonResult(filteredFlights);
        }


        public IActionResult FlightData()
        {
            var result = _context.Flights.ToList();
            return new JsonResult(result);
        }

        public IActionResult BookNow(int flightId)
        {
            var result = _context.Flights.FirstOrDefault(f => f.FlightId == flightId);

            return View(result);
        }

        [HttpPost]
        public IActionResult ConfirmBooking(Booking model)
        {
            if (ModelState.IsValid)
            {            
                    var booking = new Booking()
                {
                    FlightId = model.FlightId,
                    PassengerName = model.PassengerName,
                    NumberOfSeats = model.NumberOfSeats,
                    PassengerContact = model.PassengerContact,
                    TotalPrice = model.TotalPrice
                };
                _context.Bookings.Add(booking);
                _context.SaveChanges();
                return RedirectToAction("PaymentView");
            }
            else
            {
                return View(model);
            }
            
        }
        public IActionResult PaymentView(Payment model)
        {
            if (ModelState.IsValid)
            {
                var payment = new Payment()
                {
                    CardNumber = model.CardNumber,
                    ExpiryDate = model.ExpiryDate,
                    CVV = model.CVV
                };
                _context.Payments.Add(payment);
                _context.SaveChanges();              
                return RedirectToAction("Index");
               
            }
            else
            {
                ViewBag.ErrorMessage = "Payment failed. Please try again.";
                return View(model);
            }
        }
        public IActionResult Ticket(int flightId)
        {
            var result = _context.Flights.FirstOrDefault(f => f.FlightId == flightId);

            return View(result);
        }
       

    }
}
