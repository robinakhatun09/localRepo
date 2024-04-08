using System;

//class Vehicle
//{
//    public string brand = "Ford";
//    public void Honk()
//    {
//        Console.WriteLine("tuuuuuuuuuuuuu");
//    }
//}

//class Car : Vehicle
//{
//    public string name = "Mustang";
//}

//class Test
//{
//    static void Main()
//    {
//        Car car = new Car();
//        car.Honk();
//        Console.WriteLine(car.name);
//    }
//}

//public class cal
//{
//    public static int add(int a)
//    {
//        return a;
//    }
//    public static int add(int a, int b)
//    {
//        return a + b;
//    }

//    public class test
//    {
//        public static void Main()
//        {
//            Console.WriteLine(cal.add(1));
//            Console.WriteLine(cal.add(2, 2));
//        }
//    }
//}
//public class Animal
//{
//    public virtual void eat()
//    {
//        Console.WriteLine("eaating ");
//    }
//    public class Dog : Animal
//    {
//        public override void eat()
//        {
//            base.eat();
//            Console.WriteLine("eating bread..");
//        }
//    }
//    public class test
//    {
//        public static void Main(string[] args)
//        {
//            Animal a = new Animal();
//            a.eat();

//        }
//    }
//}

//public class employee
//{
//    private string employeename;
//    private int employeeage;
//    public string name
//    {
//        get { return employeename; }
//        set { employeename = value; }
//    }
//    public int age
//    {
//        get { return employeeage; }
//        set { employeeage = value; }
//    }
//}
//class test
//{
//    static public void main()
//    {
//        employee emp = new employee();
//        emp.name = "rubina";
//        emp.age = 23;
//        Console.WriteLine(emp.name);
//        Console.WriteLine(emp.age);
//    }
//}

//public abstract class Shape
//{
//    public abstract void draw();
//}
//public class Rectangle : Shape
//{
//    public override void draw()
//    {
//        Console.WriteLine("drawing rectangle...");
//    }
//}
//public class Test
//{
//    public static void Main()
//    {
//        Shape s;
//        s = new Rectangle();
//        s.draw();

//    }
//}


//public interface drawable
//{
//    void draw();
//}
//public class rectangle : drawable
//{
//    public void draw()
//    {
//        Console.WriteLine("drawing rectangle...");
//    }
//}

//public class testinterface
//{
//    public static void main()
//    {
//        drawable d;
//        d = new rectangle();
//        d.draw();

//    }
//}