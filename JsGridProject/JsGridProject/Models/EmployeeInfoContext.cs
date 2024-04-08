using Microsoft.EntityFrameworkCore;

namespace JsGridProject.Models
{
    public class EmployeeInfoContext:DbContext
    {
        public EmployeeInfoContext(DbContextOptions options) : base(options) { }
        public DbSet<EmployeeInformation> EmployeeInformations { get; set; }

    }
}
