using System;

namespace Question06
{
    class Program
    {
        static void Main(string[] args)
        {
            bool debug = false;

            Table[] table = new Table[10];
            Random rnd = new Random();

            for (int i = 0; i <= 10; i++) {
                if ((i % 2 == 0) && (i != 1))
                {
                    table[i - 1] = new Table(rnd.Next(50, 201), rnd.Next(50, 201));
                    table[i - 1].ShowData();
                }
                else { 
                    table[i - 1] = new CoffeTable(rnd.Next(40, 121), rnd.Next(40, 121));
                    table[i - 1].ShowData();
                }
            }
            if (debug) {
                Console.ReadLine();
            }
        }
    }
}
