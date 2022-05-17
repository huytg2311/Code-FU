using System;
using System.IO;
using System.Text;

namespace f
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Demo File System *****\n");
            using FileStream fStream = File.Open("MyFile.dat", FileMode.Create);
            string msg = "ABCDFEG";
            byte[] msgAsByteArray = Encoding.Default.GetBytes(msg);
            fStream.Write(msgAsByteArray, 0, msgAsByteArray.Length);
            fStream.Position = 0;

            Console.WriteLine("Print message as an array of byte: \n");
            byte[] bytesFromFile = new byte[msgAsByteArray.Length];
            for (int i = 0; i < msgAsByteArray.Length; i++)
            {
                bytesFromFile[i] = (byte)fStream.ReadByte();
                Console.Write($"{bytesFromFile[i],5}");
            }
            Console.Write("\nDecoded Message: ");
            Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
            Console.ReadLine();

        }

    }
}
