using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question05
{
    class Door
    {
        private string color;

        public Door() { 
            Color = "Brown";
        }

        public Door(string color) { 
            this.Color = color;
        }

        protected string Color { get => color; set => color = value; }

        public void ShowData() {
            Console.WriteLine("I am a door, my color is " + color);
        }
    }
}
