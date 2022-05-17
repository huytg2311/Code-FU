using System;
using System.Threading;

namespace Question03
{
    class Program
    {
        static void Main(string[] args)
        {
            File file = new File();
            Thread[] threads = new Thread[10];

            for (int i = 0; i < 10; i++) {
                threads[i] = new Thread(new ParameterizedThreadStart(file.Write));
                threads[i].Start($"c:\\accounts{i}.txt");
            }
        }
    }
}
