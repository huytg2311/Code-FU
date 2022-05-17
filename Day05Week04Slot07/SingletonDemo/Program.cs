using System;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler1 = ChocolateBoiler.GetInstance();
            Console.Write("boiler1\n\t");
            boiler1.Fill();
            Console.Write("boiler1\n\t");
            boiler1.Boil();
            Console.Write("boiler1\n\t");
            boiler1.Drain();
        }
    }
}
