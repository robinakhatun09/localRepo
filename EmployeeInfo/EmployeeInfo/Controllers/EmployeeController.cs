using BuisnessLogicLayer.Interface;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeInfo.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeBLL _employeeBLL;
        public EmployeeController(IEmployeeBLL employeeBLL)
        {
            _employeeBLL = employeeBLL;
        }
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult GetData()
        {
            var result = _employeeBLL.GetAllStudentsFromDAL();
            return Json(result);
        }      
        [HttpPost]
        public IActionResult Create(Employee std)
        {
            if (ModelState.IsValid)
            {
                var data = _employeeBLL.AddStudentToDAL(std);
                return Json(data);
            }
            return View(std);
        }
        [HttpPost]
        public IActionResult Edit(Employee std)
        {
            if (ModelState.IsValid)
            {
                var data = _employeeBLL.UpdateStudentFromDAL(std);
                return Json(data);
            }
            return View(std);
        }

        public IActionResult Delete(int id)
        {
            if (id > 0)
            {
                var data = _employeeBLL.DeleteStudentFromDAL(id);
                return Json(data);
            }
            return RedirectToAction("Index");
        }
    }
}
