using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public class IStudentRepositery
    {
        Task<IEnumberable<Student>> StudentAsync();
        //Task<Student> GetStudent(int id);
        //Task<bool> CreateStudent(Student student);
        //Task<Student> UpdateStudent(Student student);
        //Task<bool> DeleteStudent(int id);

    }
}
