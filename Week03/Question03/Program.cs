using System;

namespace Question03
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Console.WriteLine("Name: " + customer.getName() + ", Address: " + customer.getAddress());
        }
    }
}
