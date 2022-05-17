using System;
using System.IO;

namespace Question01
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileW = @"F:\files\males\Names.txt";
            StreamWriter sw = new StreamWriter(fileW, true);
            sw.WriteLine("John");
            sw.WriteLine("Ahmad");
            sw.Close();

            string fileR = @"F:\files\males\Names.txt";
            System.IO.StreamReader sr = new System.IO.StreamReader(fileR);
            Console.WriteLine(sr.ReadToEnd());
            Console.WriteLine("File ended");
            sr.Close(); 
        }
    }
}
