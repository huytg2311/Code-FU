using System;
using System.IO;

namespace FileInf
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileName = @"MyFile.txt";
            Console.WriteLine("***** Demo FileInfo Class *******\n");
            File.WriteAllText(FileName, "Hello World.");
            Console.WriteLine("Read file: ");
            string content = File.ReadAllText(FileName);
            Console.WriteLine(content);
            Console.WriteLine("File information: ");
            FileInfo testFile = new FileInfo(FileName);
            Console.WriteLine($"Name: {testFile.Name}");
            Console.WriteLine($"Creation Time: {testFile.CreationTime}");
            Console.WriteLine($"Last Write Time: {testFile.LastWriteTime}");
            Console.WriteLine($"Directory Name: {testFile.DirectoryName}");
            Console.ReadLine();
        }
    }
}
