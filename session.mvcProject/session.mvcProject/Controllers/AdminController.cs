using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using session.mvcProject.Models;

namespace session.mvcProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserContext _context;
        

        public AdminController(UserContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                var user = new User()
                {
                    Name = model.Name,
                    Email = model.Email,
                    Contact = model.Contact,
                    Course = model.Course,
                    Batch = model.Batch,
                    Password = model.Password,
                    ConfirmPassword = model.ConfirmPassword
                };
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
        public IActionResult Login(string email, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email);
            if (user != null && password == user.Password)
            {
                HttpContext.Session.SetString("UserSession", user.Email);
                return RedirectToAction("About");
            }           
            return RedirectToAction("Index");
        }
        public IActionResult LogOut()
        {
            if (HttpContext.Session.GetString("UserSession") != null)
            {
                HttpContext.Session.Remove("UserSession");
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult CourseData()
        {
            var courses = _context.Courses.ToList();
            return Json(courses);
        }
        //public IActionResult BatchData()
        //{
        //    var courses = _context.Batches.ToList();
        //    return Json(courses);
        //}

        public IActionResult BatchData(int id)
        {

            var batches = _context.Batches.Where(e => e.Course.CourseId == id).ToList();

            return Json(batches);
        }
        public IActionResult About()
        {
            if (HttpContext.Session.GetString("UserSession") != null)
            {
                ViewBag.MySession= HttpContext.Session.GetString("UserSession").ToString();
            }
            else
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult UserData() 
        {
            //var user = _context.Users.ToList();
            //return Json(user);

            var usersWithDetails = _context.Users
          .Join(
              _context.Batches,
              user => user.Batch,
              batch => batch.BatchId.ToString(),
              (user, batch) => new { User = user, Batch = batch }
          )
          .Join(
              _context.Courses,
              userBatch => userBatch.User.Course,
              course => course.CourseId.ToString(),
              (userBatch, course) => new
              {
                  userBatch.User.Id,
                  userBatch.User.Name,
                  userBatch.User.Email,
                  userBatch.User.Contact,
                  userBatch.User.Password,
                  userBatch.User.ConfirmPassword,
                  userBatch.User.Course,
                  userBatch.User.Batch,
                  BatchName = userBatch.Batch.BatchName,
                  CourseName = course.CourseName
              }
          )
          .ToList();

            return Json(usersWithDetails);       
        }
        public IActionResult Create(User model)
        {

            if (!ModelState.IsValid)
            {
                if (model.Name == null || model.Name == "")
                {
                    return Json(new { success = false, error = "name is required" });
                }
                if (model.Email == null || model.Email == "")
                {
                    return Json(new { success = false, error = "Email is required" });
                }
                if (model.Contact == null || model.Contact == "")
                {
                    return Json(new { success = false, error = "Contact is required" });
                }
                if (model.Course == null || model.Course == "")
                {
                    return Json(new { success = false, error = "Course is required" });
                }
                if (model.Batch == null || model.Batch == "")
                {
                    return Json(new { success = false, error = "Batch is required" });

                }
                if (model.Password == null || model.Password == "")
                {
                    return Json(new { success = false, error = "Password is required" });
                }
                if (model.ConfirmPassword == null || model.ConfirmPassword == "")
                {
                    return Json(new { success = false, error = "ConfirmPassword is required" });
                }

                var student = new User()
                {
                    Name = model.Name,
                    Email = model.Email,
                    Contact = model.Contact,
                    Course = model.Course,
                    Batch = model.Batch,
                    Password = model.Password,
                    ConfirmPassword = model.ConfirmPassword,

                };
                
                _context.Users.Add(student);
                _context.SaveChanges();
                return Json(new { success = true, error = "data inserted succesfully" });
            }
            return View();
        }
        public IActionResult Edit(User stu)
        {
            _context.Users.Update(stu);
            _context.SaveChanges();
            return Json(new { success = true, error = "data update succesfully" });
        }
        public IActionResult Delete(int Id)
        {
            var st = _context.Users.Find(Id);
            _context.Users.Remove(st);
            _context.SaveChanges();
            return RedirectToAction("About");

        }

    }
}
