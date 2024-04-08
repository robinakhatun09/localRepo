using System;
using System.Linq;
//namespace Linq_demo
//{
//    class program
//    {
//        static void Main(string[] args)
//        {
//            int[] age = { 15, 22, 43, 21 };
//            var a = from x in age where x > 20 orderby x descending select x;
//            //string[] name = { "ruby","rubina","shivam","shri" };
//            //var a = from x in name where x.Contains("r") orderby x descending select x;
//            //var z = from x in name where x.StartsWith("r") orderby x descending select x;
//            //var z = from x in name where x.EndsWith("a") orderby x descending select x;
//            foreach (int item in a)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}

class Student
{
    public int StudentID { get; set; }
    public string? StudentName { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Student[] studentArray = {
            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
            new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
            new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
            new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
        };

        foreach (Student std in studentArray)
        {
            if (std.Age > 20 && std.Age < 31)
            {

                Console.WriteLine(std.Age);

            }

        }
    }
}
//class Student
//{
//    public int StudentID { get; set; }
//    public string? StudentName { get; set; }
//    public int Age { get; set; }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Student[] studentArray = {
//            new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
//            new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
//            new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
//            new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
//            new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
//            new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
//        };
//        var teenAgerStudents = from x in studentArray where x.StudentName != null && x.StudentName.StartsWith("R") orderby x.StudentName select x;
//        foreach (Student item in teenAgerStudents)
//        {
//            Console.WriteLine($"StudentID: {item.StudentID}, StudentName: {item.StudentName}, Age: {item.Age}");

//        }

//    }
//}

