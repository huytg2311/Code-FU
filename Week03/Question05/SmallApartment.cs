using System;

namespace Question05
{
    internal class SmallApartment : House
    {
        public SmallApartment() : base(50)
        {
        }

        public override void ShowData()
        {
            Console.WriteLine("I am apartment, my area is " + area + " m2");
        }
    }
}