using System;
using System.Reflection;

namespace EnumeratingAssemblies
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain defaultAD = AppDomain.CurrentDomain;
            Assembly[] loadedAssemblies = defaultAD.GetAssemblies();
            Console.WriteLine("The assemblies loaded in {0}", defaultAD.FriendlyName);
            foreach (Assembly a in loadedAssemblies) {
                Console.WriteLine($"--Name, Version: {a.GetName().Name}:{a.GetName().Version}");
            }
            Console.ReadLine();
        }
    }
}
