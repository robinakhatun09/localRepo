using entityframework.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace entityframework.Controllers
{
    public class studentlistController1 : Controller
    {
        private readonly 

        public studentlistController1(MVCDemoDbContext mvcemoDbContext) { }




        [HttpGet]
        public IActionResult student()
        {
            return View();
        }



        [HttpPost]
        public IActionResult student(studentlist addStudentRequest)
        {
            var student = new studentlist()
            {
                Id = Guid.NewGuid(),
                Name = addStudentRequest.Name,
                Email = addStudentRequest.Email,
                Number = addStudentRequest.Number,
                country = addStudentRequest.country,
                Gender = addStudentRequest.Gender,
            };
            mvcDemoDbContext.students.student(student);
            mvcDemoDbContext.saveChanges();
            return RedirectToAction("student");
        }
    }

    public class MVCDemoDbContext
    {
    }
}
