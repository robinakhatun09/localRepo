using System.ComponentModel.DataAnnotations;

namespace KendoDynamicGrid.Models
{
    public class Student
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Email { get; set; }
       
        public string Contact { get; set; }
        public string Course {  get; set; }
       
        public string City { get; set; }
        
    }
    //public class ChildStudent:Student
    //{

    //} 

}
