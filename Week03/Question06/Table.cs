using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question06
{
    class Table
    {
        protected float width, height;

        public Table() { 
        }

        public Table(float width, float height) { 
            this.width = width;
            this.height = height;
        }

        public float Width {           
            set { width = value; }
            get { return width; }
        }

        public float Height { 
            set { height = value; }
            get { return height; }
        }

        public virtual void ShowData() {
            Console.WriteLine("Width: {0}, Height: {1}", width, height);
        }
    }
}
