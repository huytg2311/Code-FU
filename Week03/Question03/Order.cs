using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question03
{
    class Order
    {
        private DateTime date;
        private string status;

        protected OrderDetail[] o;

        protected DateTime Date { get => date; set => date = value; }
        protected string Status { get => status; set => status = value; }

        public Order() {
            status = "";
        }

        public double calcTax() {
            return 0;
        }
        public double calcTotal() { 
            return 0;
        }
        public double calcTotalWeight() {
            return 0;
        }
        
    }
}
