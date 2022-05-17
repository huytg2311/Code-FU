using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question01
{
    class Person
    {
        protected int age;
        public void Greet() {
            Console.WriteLine("Hello");
        }
        public void setAge(int n) {
            age = n;
        }
    }
}
