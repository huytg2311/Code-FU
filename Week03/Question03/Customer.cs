using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question03
{
    class Customer
    {
        protected string name;
        protected string address;
        protected Order[] o;
        public Customer() { 
            name = "Join";
            address = "America";
        }

        public string getName() {
            return name;
        }

        public string getAddress() {
            return address;
        }
        
    }
}
