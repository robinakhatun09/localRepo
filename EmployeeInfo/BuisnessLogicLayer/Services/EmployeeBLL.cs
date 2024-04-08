using BuisnessLogicLayer.Interface;
using DataAccessLayer.Interface;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogicLayer.Services
{
    public class EmployeeBLL:IEmployeeBLL
    {
        private readonly IEmployeeDAL _studentDAL;
        public EmployeeBLL(IEmployeeDAL studentDAL)
        {
            _studentDAL = studentDAL;
        }

        public Employee AddStudentToDAL(Employee std)
        {
            var dt = _studentDAL.AddStudentToDB(std);
            return dt;
        }

        public Employee DeleteStudentFromDAL(int id)
        {
            var dt = _studentDAL.DeleteStudentFromDB(id);
            return dt;
        }

        List<Employee> IEmployeeBLL.GetAllStudentsFromDAL()
        {
            return _studentDAL.GetAllStudentFromDB();
        }

        public Employee GetStudentByIdFromDAL(int id)
        {
            var dt = _studentDAL.GetStudentByIdFromDB(id);
            return dt;
        }

        public Employee UpdateStudentFromDAL(Employee std)
        {
            var dt = _studentDAL.UpdateStudentFromDB(std);
            return dt;
        }

    }
}
