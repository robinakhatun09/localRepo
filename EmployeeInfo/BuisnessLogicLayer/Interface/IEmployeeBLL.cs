using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogicLayer.Interface
{
    public interface IEmployeeBLL
    {
        List<Employee> GetAllStudentsFromDAL();
        Employee GetStudentByIdFromDAL(int id);
        Employee AddStudentToDAL(Employee std);
        Employee DeleteStudentFromDAL(int id);
        Employee UpdateStudentFromDAL(Employee std);

    }
}
