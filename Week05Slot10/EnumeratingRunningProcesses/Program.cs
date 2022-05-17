using System;
using System.Diagnostics;
using System.Linq;

namespace EnumeratingRunningProcesses
{
    class Program
    {
        static void Main(string[] args)
        {
            int no = 1;
            string info;

            var runningProcs = from proc in Process.GetProcesses(".") orderby proc.Id select proc;
            foreach (var p in runningProcs) {
                info = $"#{no++}. PID: {p.Id}\tName: {p.ProcessName}";
                Console.WriteLine(info);
            }
            Console.ReadLine();
        }
    }
}
