using System;

namespace Question01
{
    public delegate double PerformCalculation(double a, double b);

    class Program
    {
        public static double Addition(double a, double b) {
            return a + b;
        }

        public static double Division(double a, double b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            PerformCalculation getSum = Addition;
            double result = getSum(9, 10);
            Console.WriteLine("The result is {0}", result);

            PerformCalculation getDivision = Division;
            result = getDivision(20, 10);

            Console.WriteLine("The result is {0}", result);

            Console.ReadLine();
        }
    }
}
