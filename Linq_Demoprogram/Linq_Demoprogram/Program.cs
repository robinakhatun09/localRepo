using System;
using System.Linq;
namespace Linq_Demoprogram
{
    //class program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] age = { 15, 22, 43, 21 };
    //        var a = from x in age where x > 20 orderby x descending select x;
    //string[] name = { "ruby","rubina","shivam","shri" };
    //var a = from x in name where x.Contains("r") orderby x descending select x;
    //var z = from x in name where x.StartsWith("r") orderby x descending select x;
    //var z = from x in name where x.EndsWith("a") orderby x descending select x;
    //        foreach (int item in a)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}
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
    //        new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
    //        new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
    //        new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
    //        new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
    //        new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
    //        new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
    //    };

    //        foreach (Student std in studentArray)
    //        {
    //            if (std.Age > 20 && std.Age < 31)
    //            {

    //                Console.WriteLine(std.Age);

    //            }

    //        }
    //    }
    //}
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
    //            new Student() { StudentID = 4, StudentName = "Ram" , Age = 18 },
    //            new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
    //            new Student() { StudentID = 6, StudentName = "Chris",  Age = 18 },
    //            new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
    //        };
    //var teenAgerStudents = from x in studentArray where x.StudentName != null && x.StudentName.StartsWith("R") orderby x.StudentName select x;

    //foreach (Student item in teenAgerStudents)
    //{
    //    Console.WriteLine($"StudentID: {item.StudentID}, StudentName: {item.StudentName}, Age: {item.Age}");

    //}
    //        var groupedByAge = from student in studentArray
    //                           group student by student.Age into ageGroup
    //                           orderby ageGroup.Key
    //                           select new
    //                           {
    //                               Age = ageGroup.Key,
    //                               Students = ageGroup
    //                           };

    //        foreach (var ageGroup in groupedByAge)
    //        {
    //            Console.WriteLine($"Age: {ageGroup.Age}");
    //            foreach (var student in ageGroup.Students)
    //            {
    //                Console.WriteLine($"  StudentID: {student.StudentID}, StudentName: {student.StudentName}, Age: {student.Age}");
    //            }
    //        }


    //    }
    //}
    //public class Program
    //{
    //    public static void Main()
    //    {
    //        // Student collection
    //        IList<string> strList1 = new List<string>() {
    //        "One",
    //        "Two",
    //        "Three",
    //        "Four"
    //        };

    //        IList<string> strList2 = new List<string>() {
    //        "One",
    //        "Two",
    //        "Five",
    //        "Six"
    //        };

    //        var innerJoinResult = strList1.Join(
    //                      strList2,  
    //                      str1 => str1,    
    //                      str2 => str2,  
    //                      (str1, str2) => str1);

    //        foreach (var str in innerJoinResult)
    //        {
    //            Console.WriteLine("{0} ", str);
    //        }

    //    }
    //}
    //    public class Program
    //    {
    //        public static void Main()
    //        {
    //            IList<Student> studentList = new List<Student>() {
    //                new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
    //                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
    //                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
    //                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
    //                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
    //            };

    //            IList<Standard> standardList = new List<Standard>() {
    //                new Standard(){ StandardID = 1, StandardName="Standard 1"},
    //                new Standard(){ StandardID = 2, StandardName="Standard 2"},
    //                new Standard(){ StandardID = 3, StandardName="Standard 3"}
    //            };

    //            var innerJoinResult = studentList.Join(
    //                          standardList, 
    //                          student => student.StandardID,   
    //                          standard => standard.StandardID, 
    //                          (student, standard) => new  
    //                          {
    //                              StudentName = student.StudentName,
    //                              StandardName = standard.StandardName
    //                          });

    //            foreach (var obj in innerJoinResult)
    //            {

    //                Console.WriteLine("{0} - {1}", obj.StudentName, obj.StandardName);
    //            }

    //        }

    //    }

    //    public class Student
    //    {

    //        public int StudentID { get; set; }
    //        public string StudentName { get; set; }
    //        public int Age { get; set; }
    //        public int StandardID { get; set; }
    //    }

    //    public class Standard
    //    {

    //        public int StandardID { get; set; }
    //        public string StandardName { get; set; }
    //    }

    public class Program
    {
        public static void Main()
        {
            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
            IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };
            var result = strList1.Distinct();
            //var result = strList1.Intersect(strList2);
            // var result = strList1.Union(strList2);
            //var result = strList1.Except(strList2);



            foreach (string str in result)
                Console.WriteLine(str);
        }
    }
}