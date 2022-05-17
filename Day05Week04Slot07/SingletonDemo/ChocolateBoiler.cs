using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class ChocolateBoiler
    {
        private bool Empty { get; set; }
        private bool Boiled { get; set; }

        private static ChocolateBoiler uniqueInstance;
        private ChocolateBoiler() {
            Empty = true;
            Boiled = false;
        }
        public static ChocolateBoiler GetInstance() {
            if (uniqueInstance == null)
            {
                if (uniqueInstance == null)
                {
                    Console.WriteLine("Creating new, unique instance of ChocolateBoiler");
                    uniqueInstance = new ChocolateBoiler();
                }
            }   else {
                Console.WriteLine("Using the previously created instance of ChocolateBoiler");

            }
            return uniqueInstance;
        }

        public void Fill() {
            if (!Empty) {
                Console.WriteLine();
                return;
            }
            Empty = false;
            Boiled = false;
            Console.WriteLine("Fill the boiler with a milk/chocolate mixture");
        }

        public void Drain()
        {
            if (Empty || !Boiled)
            {
                Console.WriteLine();
                return;
            }
            Console.WriteLine("Drain the boiled milk and chocolate.");
            Empty = true;
        }
        public void Boil()
        {
            if (Empty || Boiled)
            {
                Console.WriteLine();
                return;
            }
            Console.WriteLine("Bring the contents to a boil.");
            Boiled = true;
        }


    }
}
