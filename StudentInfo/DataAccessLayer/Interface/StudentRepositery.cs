using DataAccessLayer.Data;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public class StudentRepositery: IStudentRepositery
    {
        private readonly ApplicationDbContext _dbContext;

        public StudentRepositery(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }    

        public Task<List<Student>> GetStudentList()
        {
           
        }

    }
}
