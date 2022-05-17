using System;
using System.Threading;

namespace ThreadStartDelegate
{
    class Program
    {
    static void Main(string[] args)
        {
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "Primary";
            Console.WriteLine($"{Thread.CurrentThread.Name} is executing Main()");
            Printer p = new Printer();
            Thread backgroundThread = new Thread(new ThreadStart(p.PrintNumbers));
            backgroundThread.Name = "Secondary";
            backgroundThread.Start();
            for (int i = 1; i <= 5; i++) {
                Console.WriteLine($"Main thread : {i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine("The main thread has finished");
            Console.ReadLine();
        }
    }

    public class Printer {
        public void PrintNumbers() {
            Console.WriteLine($"{Thread.CurrentThread.Name} is executing PrintNumber()");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Second thread: {i}");
                Thread.Sleep(2000);
            }
            Console.WriteLine();
        }
    }
}
