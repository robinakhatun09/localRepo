using BuissessLogicLayer.LogicServices;
using BuissnessObjectLayer.Entities;
using DataAccessLayer.DataServices;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CustomerPortal.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomer _customer;
        public CustomerController(ICustomer customer)
        {
            _customer = customer;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Customer> result = new List<Customer>();
            result = _customer.GetCustomers().ToList();
            return View(result);
        }
    }
}
