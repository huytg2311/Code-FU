using System;

namespace MyClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass { x = 1 };
            Console.WriteLine($"x:{obj.x}, y: {obj.y}");
            MyClass obj1 = new MyClass();
            Console.WriteLine($"x:{obj1.x}, y: {obj1.y}");
            MyClass obj2 = new MyClass(30, 50);
            Console.WriteLine($"x:{obj2.x}, y: {obj2.y}");
            Console.ReadLine();
        }
    }
}
