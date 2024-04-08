using KendoDynamicGrid.Models;
using Microsoft.AspNetCore.Mvc;

namespace KendoDynamicGrid.Controllers
{
    public class StudentController : Controller

    {
        private readonly Studentcontext _context;
        public StudentController(Studentcontext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            var result = _context.Students.OrderBy(x => x.Id).ToList();
            return Json( result );
        }
        [HttpPost]
        public IActionResult Create(Student model) {

            if (!ModelState.IsValid)
            {
                if (model.Name==null || model.Name=="")
                {
                    return Json(new {success=false,error="name is required"});
                }
                var student = new Student()
                {
                    Name = model.Name,
                    Email = model.Email,
                    Contact = model.Contact,
                    Course = model.Course,
                    City = model.City
                };
                //var Child = new ChildStudent();
                //Child.Id = student.Id;
                //Child.Name = student.Name;                    
                //Child.Email = student.Email;
                _context.Students.Add(student);
                _context.SaveChanges();
                return Json(new { success = true, error = "data inserted succesfully" });
            }
            return View();
        }
       
        public IActionResult Edit(Student stu)
        {
            _context.Students.Update(stu);
            _context.SaveChanges();
            return Json(stu);

        }
        public IActionResult Delete(int Id)
        {
            var st = _context.Students.Find(Id);
            _context.Students.Remove(st);
            _context.SaveChanges();
            return RedirectToAction("Details");

        }
    }
}
