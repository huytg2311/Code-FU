using System;

namespace CustomerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer obj = new Customer();
            obj.CustomerID = 1000;
            Console.WriteLine($"ID: {obj.CustomerID}, Name: {obj.CustomerName}");
            obj.CustomerID = 2000;
            obj.CustomerName = "Jack";
            obj.Print();
            Console.ReadLine();
        }
    }
}
