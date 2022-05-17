using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDemo
{
    class Customer
    {
        private int id;
        public int CustomerID {
            get {
                return id;
            }
            set {
                id = value;
            }
        }
        public string CustomerName
        {
            get; set;
        } = "New Customer";
        public void Print() {
            Console.WriteLine($"ID: {CustomerID}, Name: {CustomerName}");
        }
    }
}
