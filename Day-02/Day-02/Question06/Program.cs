using System;

namespace Question06
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (command) {
                case "cong":
                    Cong(a, b);
                    break;
                case "tru":
                    Tru(a, b);
                    break;
                case "nhan":
                    Nhan(a, b);
                    break;
                case "chia":
                    Chia(a, b);
                    break;
            }
        }
        private static void Cong(int a, int b) {
            Console.WriteLine(a + b);
        }
        private static void Tru(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        private static void Nhan(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        private static void Chia(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}
