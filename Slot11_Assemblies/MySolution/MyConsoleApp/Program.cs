using static System.Console;
using static MyLibrary.MyClass;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50, b = 25;
            int result;
            WriteLine("******Demo Consuming Assemblies******");
            result = a.Add(b);
            WriteLine($"{a}+{b}={result}");
            result = a.Sub(b);
            WriteLine($"{a}-{b}={result}");
            ReadLine();
        }
    }
}
