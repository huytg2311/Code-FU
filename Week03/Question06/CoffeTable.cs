using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question06
{
    class CoffeTable : Table
    {
        public CoffeTable(float width, float height) { 
            this.width = width;
            this.height = height;
        }

        public override void ShowData() {
            Console.WriteLine("(Coffee table) Width: {0}, Height: {1}", width, height);
        }
    }
}
