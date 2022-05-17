using System;
using System.Threading;

namespace DemoThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "The Primary Thread";
            Console.WriteLine($"ID of current thread: {primaryThread.ManagedThreadId}");
            Console.WriteLine($"Thread Name: {primaryThread.Name}");
            Console.WriteLine("Has thread started?: {primaryThread.IsAlive}");
            Console.WriteLine("Priority Level: {primaryThread.Priority}");
            Console.WriteLine("Thread State: {primaryThread.Priority}");
            Console.ReadLine();
        }
    }
}
