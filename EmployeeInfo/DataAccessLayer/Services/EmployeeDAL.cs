using DataAccessLayer.DbContextClasses;
using DataAccessLayer.Interface;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services
{
    public class EmployeeDAL : IEmployeeDAL
    {
        private readonly EmployeeContext _context;
        public EmployeeDAL(EmployeeContext context)
        {
            _context = context;
        }

        public Employee AddStudentToDB(Employee std)
        {
            _context.Employees.Add(std);
            _context.SaveChanges();
            return std;
        }

        public Employee DeleteStudentFromDB(int id)
        {
            var dt = _context.Employees.Find(id);
            if (dt != null)
            {
                _context.Employees.Remove(dt);
                _context.SaveChanges();
            }
            return dt;
        }

        public List<Employee> GetAllStudentFromDB()
        {
            var result = _context.Employees.OrderBy(x => x.Id).ToList();
            return result;
        }

        public Employee GetStudentByIdFromDB(int id)
        {
            var dt = _context.Employees.FirstOrDefault(x => x.Id == id);
            return dt;
        }

        public Employee UpdateStudentFromDB(Employee std)
        {

            _context.Employees.Update(std);
            _context.SaveChanges();

            return std;
        }
    }
}
