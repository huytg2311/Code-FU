using System;

namespace Question04
{
    class Table {
        private float width, height;

        public Table() { }

        public Table(float width, float height) { 
            this.Width = width;
            this.Height = height;
        }

        public float Width { get => width; set => width = value; }
        public float Height { get => height; set => height = value; }

        public void showData() {
            Console.WriteLine("Width: {0}, Height: {1}", width, height);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool debug = false;

            Table[] myTable = new Table[10];
            Random rand = new Random();

            for (int i = 0; i < 10; i++) { 
                myTable[i] = new Table(rand.Next(50,201), rand.Next(50,201));
                myTable[i].showData();
            }

            if (debug) {
                Console.ReadLine();
            } 
        }
    }
}
