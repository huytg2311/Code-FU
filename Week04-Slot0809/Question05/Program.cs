using System;

namespace Question05
{
    delegate void DisplayMessage();
    delegate int Multiply(int n);
    class Program
    {
        static void Main(string[] args)
        {
            Multiply MultiplyNumber = n => n * 3;
            Console.WriteLine(MultiplyNumber(30));

            DisplayMessage Message = () => Console.WriteLine("Hi from the lambda expression");
            Message();
        }
    }
}
