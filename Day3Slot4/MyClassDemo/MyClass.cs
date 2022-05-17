using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassDemo
{
    class MyClass
    {
        public int x { get; init; }
        public int y { get; }
        public MyClass() {
            x = 10;
            y = 20;
        }
        public MyClass(int a, int b) {
            x = a;
            y = b;
        }

}
    }

