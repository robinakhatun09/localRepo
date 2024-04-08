using BuisnessLayer;
using Microsoft.AspNetCore.Mvc;

namespace presentationLayer.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        //public async Task<IActionResult> Index()
        //{
        //    var student = await _studentService.GetStudentAsync();
        //    return View(student);
        //}
    }
}
