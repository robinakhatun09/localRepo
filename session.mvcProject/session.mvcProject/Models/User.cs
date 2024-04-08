namespace session.mvcProject.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Course { get; set; }
        public string Batch { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        
    }
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
           
    }
    public class Batch
    {
        public int BatchId { get; set; }
        public string BatchName { get; set; }
        public Course Course { get; set;}

    }

}
