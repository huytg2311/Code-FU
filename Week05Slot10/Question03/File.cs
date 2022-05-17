using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Question03
{
    class File
    {
        public Object thisLock = new Object();
        public void Write(object path) {
            lock (thisLock) {
                Console.WriteLine("Writing in " + path);
                Thread.Sleep(2000);
                Console.WriteLine("Writing process has been completed");
            }
        }

        public void Read(object path) {
            lock (thisLock) {
                Console.WriteLine("Reading from " + path);
                Thread.Sleep(1000);
                Console.WriteLine("Reading process has been completed");
            }
        }
    }
}
