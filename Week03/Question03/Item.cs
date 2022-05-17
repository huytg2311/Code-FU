using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question03
{
    class Item : OrderDetail
    {
        private string shippingWeight;
        private string descriptions;

        protected string ShippingWeight { get => shippingWeight; set => shippingWeight = value; }
        protected string Descriptions { get => descriptions; set => descriptions = value; }

        public Item() { 
            ShippingWeight = "";
            Descriptions = "";
        }

        public double getPriceForQuantity() {
            return 0;
        }

        public double getWeigth() {
            return 0;
        }
    }
}
