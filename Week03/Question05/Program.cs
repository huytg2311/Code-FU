using System;

namespace Question05
{
    class Program
    {
        static void Main(string[] args)
        {
            bool debug = false;

            SmallApartment myApartment = new SmallApartment();
            Person myPerson = new Person();

            myPerson.Name = "John";
            myPerson.House = myApartment;
            myPerson.ShowData();

            if (debug) {
                Console.ReadLine();

            }

        }
    }
}
