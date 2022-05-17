using System;

namespace Day_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Menu Driven Program for Switch case");
            //while (true) {
            //    Console.WriteLine("1. Factorial");
            //    Console.WriteLine("2. Prime or not");
            //    Console.WriteLine("3. Odd or Even");
            //    Console.WriteLine("4. Press number 4 to exit");
            //    Console.WriteLine("Enter your choice: ");
            //    int choice = Convert.ToInt32(Console.ReadLine());

            //}

            int x = 1, y = 2, z;
            MyMethod(x,ref y, out z);
            Console.WriteLine($"x:{x}, y: {y}, z: {z}");
            Console.ReadLine();


        }

        public static void MyMethod(int a, ref int b, out int c) {
            a = 3;
            b = 4;
            c = 5;
        }

        
    }
}
