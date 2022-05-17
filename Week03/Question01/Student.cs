using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question01
{
    class Student : Person
    {
        public void ShowAge() {
            Console.WriteLine("My age is {0} year old", age);
        }
    }
}
