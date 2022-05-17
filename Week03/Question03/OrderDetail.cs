using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question03
{
    
    class OrderDetail
    {
        protected Item[] i;
        protected double quantity;
        protected string taxStatus;

        public OrderDetail() {
            quantity = 0.0;
            taxStatus = "";
        }

        public double calcSubTotal() {
            return 0;
        }

        public double calcWeight() {
            return 0;
        }
    }
}
