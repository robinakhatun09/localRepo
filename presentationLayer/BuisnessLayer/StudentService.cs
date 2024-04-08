using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer
{
    public class StudentService:IStudentService
    {
       private readonly IStudentService _studentService;
        public StudentService(IStudentService studentService)
        {
            _studentService = studentService;
        }
        //public async Task<IEnumerable<StudentService>> GetStudentsAsync()
        //{
        //    return await _studentService.GetStudentsAsync();
        //}
    }
}
