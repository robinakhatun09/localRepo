using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        var myList1 = new List<int>();
        myList1.Add(1);
        myList1.Add(3);
        myList1.Add(4);
        myList1.Insert(1, 2);
        //myList1.Remove(1);
        //myList1.RemoveAt(1);
        Console.WriteLine(myList1.Contains(2));
        Console.WriteLine("List 1:");
        DisplayList(myList1);

        var myList2 = new List<int> { 5, 6, 7 };  //Collection initializer.    
        Console.WriteLine("List 2:");
        DisplayList(myList2);
        myList1.AddRange(myList2);

        Console.WriteLine("Merged List:");
        DisplayList(myList1);

    }

    static void DisplayList(List<int> list)
    {
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
//public class StackExample
//{
//    public static void Main(string[] args)
//    {
//        Stack<string> names = new Stack<string>();
//        names.Push("Sonoo");
//        names.Push("Peter");
//        names.Push("James");
//        names.Push("Ratan");
//        names.Push("Irfan");

//        foreach (string name in names)
//        {
//            Console.WriteLine(name);
//        }

//        Console.WriteLine("Peek element: " + names.Peek());
//        Console.WriteLine("Pop: " + names.Pop());
//        Console.WriteLine("After Pop, Peek element: " + names.Peek());

//    }
//}
//public class QueueExample
//{
//    public static void Main(string[] args)
//    {
//        Queue<string> names = new Queue<string>();
//        names.Enqueue("Sonoo");
//        names.Enqueue("Peter");
//        names.Enqueue("James");
//        names.Enqueue("Ratan");
//        names.Enqueue("Irfan");

//        foreach (string name in names)
//        {
//            Console.WriteLine(name);
//        }

//        Console.WriteLine("Peek element: " + names.Peek());
//        Console.WriteLine("Dequeue: " + names.Dequeue());
//        Console.WriteLine("After Dequeue, Peek element: " + names.Peek());
//    }
//}
//public class DictionaryExample
//{
//    public static void Main(string[] args)
//    {
//        Dictionary<string, string> names = new Dictionary<string, string>();
//        names.Add("1", "Sonoo");
//        names.Add("2", "Peter");
//        names.Add("3", "James");
//        names.Add("4", "Ratan");
//        names.Add("5", "Irfan");
//        names["1"] = "sana"; //update name
//        names["2"] = "preety";
//        names.Remove("2");
//        //update
//        if (names.ContainsKey("1"))
//        {
//            names["1"] = "shifa";
//        }
//        foreach (KeyValuePair<string, string> kv in names)
//        {
//            Console.WriteLine(kv.Key + " " + kv.Value);
//        }
//    }
//}

//public class SortedListExample
//{
//    public static void Main(string[] args)
//    {
//        SortedList<string, string> names = new SortedList<string, string>();
//        names.Add("1", "Sonoo");
//        names.Add("4", "Peter");
//        names.Add("5", "James");
//        names.Add("3", "Ratan");
//        names.Add("2", "Irfan");
//        foreach (KeyValuePair<string, string> kv in names)
//        {
//            Console.WriteLine(kv.Key + " " + kv.Value);
//        }
//    }
//}

//public class HashSetExample
//{
//    public static void Main(string[] args)
//    {
//        // Create  set of strings  
//        var names = new HashSet<string>();
//        names.Add("Sonoo");
//        names.Add("Ankit");
//        names.Add("Peter");
//        names.Add("Irfan");
//        names.Add("Ankit");// not be added  

//        foreach (var name in names)
//        {
//            Console.WriteLine(name);
//        }
//    }
//}