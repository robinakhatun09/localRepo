using DataAccessLayer.Data;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interface
{
    public class StudentRepo:IStudentRepo
    {
        private readonly ApplicationDbContext _dbContext;
        public StudentRepo(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Student>> GetStudentsAsync()
        {
            return await _dbContext.Students.ToListAsync();
        }

    }
}
 