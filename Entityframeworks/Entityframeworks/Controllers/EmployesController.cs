using Entityframeworks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Entityframeworks.Controllers
{
    public class EmployesController : Controller
    {

        private readonly EmployeeContext context;

        public EmployesController(EmployeeContext context) {

            this.context = context;
        }



        public IActionResult Index()
        {

            var result = context.Employees.ToList();

            return View(result);
        }
        [HttpGet]
        public IActionResult ViewDetails() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult ViewDetails(Employee model)
        {
            if (ModelState.IsValid) 
            {
                var emp = new Employee()
                {
                    Id = model.Id,
                    Name= model.Name,
                    Email= model.Email,
                    Age= model.Age,
                    Address= model.Address,


                };
                context.Employees.Add(emp);
                TempData["error"] = "Record saved!";
                context.SaveChanges();
                return RedirectToAction("Index");
                
            }
            else
            {
                TempData["error"] = "empty field can't submit";
                return View(model);
            }

        }
        public IActionResult Delete(int id)
        {
            var emp=context.Employees.SingleOrDefault(e=>e.Id==id);
            context.Employees.Remove(emp);
            context.SaveChanges();
            TempData["error"] = "Record Deleted!";
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        { 
            var emp=context.Employees.SingleOrDefault(e=> e.Id==id);
            var result = new Employee()
            {
                Name = emp.Name,
                Email = emp.Email,
                Age = emp.Age,
                Address = emp.Address,

            };
           
            return View(result);
           
        }
        [HttpPost]
        public IActionResult Edit(Employee model)
        {
            var emp = new Employee()
            {
                Id = model.Id,
                Name = model.Name,
                Email = model.Email,
                Age = model.Age,
                Address = model.Address,

            };
            context.Employees.Update(emp);
            context.SaveChanges();
            TempData["error"] = "Record Update!";
            return RedirectToAction("Index");
        }
    }
}
