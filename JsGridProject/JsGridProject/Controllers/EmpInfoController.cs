using JsGridProject.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Xml.Linq;

namespace JsGridProject.Controllers
{
    public class EmpInfoController : Controller
    {
        public readonly EmployeeInfoContext _context;
        public EmpInfoController(EmployeeInfoContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult GetData()
        //{
        //    var result = _context.EmployeeInformations.ToList();
        //    return new JsonResult(result);
        //}


        public IActionResult GetData(string emailAddress)
        {
            var result = from s in _context.EmployeeInformations
                         where s.Name.Contains("a")
                         select s;
            return new JsonResult(result);
        }
            
            public IActionResult Create(EmployeeInformation model)
            {
            if (ModelState.IsValid)
            {
                var emp = new EmployeeInformation()
                {

                    Name = model.Name,
                    Email = model.Email,
                    Contact = model.Contact,
                    City = model.City


                };
                _context.EmployeeInformations.Add(emp);
                _context.SaveChanges();
                return new JsonResult(emp);
            }
            else
            {
                return View(model);
            }

        }
        public IActionResult Edit(EmployeeInformation emp)
        {

        _context.EmployeeInformations.Update(emp);
        _context.SaveChanges();
        return new JsonResult(emp);

        }

        public IActionResult Delete(int id)
        {
            var emp = _context.EmployeeInformations.Find(id);
            if (emp != null)
            {
                _context.EmployeeInformations.Remove(emp);
                _context.SaveChanges();
                return new JsonResult("Ok");
            }
            return RedirectToAction("Index");

        }


    }

}

