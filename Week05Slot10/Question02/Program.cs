using System;
using System.Threading;

namespace Question02
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(delegate ()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Hello from the anonymous method assigned to the t1 thread");
                }
            }));
            t1.Start();
        }
    }
}
