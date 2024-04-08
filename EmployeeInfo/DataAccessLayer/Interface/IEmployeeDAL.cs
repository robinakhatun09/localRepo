using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public interface IEmployeeDAL
    {
        List<Employee> GetAllStudentFromDB();
        Employee GetStudentByIdFromDB(int id);
        Employee AddStudentToDB(Employee std);
        Employee DeleteStudentFromDB(int id);
        Employee UpdateStudentFromDB(Employee std);
    }
}
