using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Question01
{
    class Thread01
    {
        int number;

        public void run() {
            Random rnd = new Random();
            for (int i = 0; i < 100; i++) {
                Thread.Sleep(2000);
                number = rnd.Next(1, 10);
                Console.WriteLine(number);
            }
            
        }
    }
}
