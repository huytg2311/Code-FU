using System;

namespace Question08
{
    class Program
    {
        static void Main(string[] args)
        {
            // part 2
            //int x = 2; int y = 3;

            //part 1
            //double width = double.Parse(Console.ReadLine());
            //double height = double.Parse(Console.ReadLine());
            //double area = GetRecTangleArea(width, height);
            //Console.WriteLine(area);

            // part 3
            Console.WriteLine("First Number: ");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Second Number: ");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine("Greatest of two: " + GetMax(first, second));
        }

        static int GetMax(int first, int second) {
            if (first > second)
            {
                return first;
            }

            else if (first < second)
            {
                return second;
            }
            else
            {
                return second;
            }
        }

        static double GetRecTangleArea(double width, double height) {
            return width * height;
        }

        static int power(int x, int y) {
            if (y == 0)
            {
                return 1;
            }
            else if (y % 2 == 0)
            {
                return power(x, y / 2) * power(x, y / 2);
            }
            else {
                return x * power(x, y / 2) * power(x, y / 2);
            }
        } 
    }
}
