using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    public delegate void Mydelegate(string msg);
    class MyClass
    {
        public static void Print(string message) =>
            Console.WriteLine($"{message.ToUpper()}");
        public static void Show(string message) =>
            Console.WriteLine($"{message.ToLower()}");
        public static void Display(string message) =>
            Console.WriteLine($"{message}");
    }
}
