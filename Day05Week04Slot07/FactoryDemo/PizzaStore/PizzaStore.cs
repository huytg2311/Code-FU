using FactoryDemo.PizzaProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDemo.PizzaStore
{
    public abstract class PizzaStore
    {
        protected abstract Pizza CreatePizza(string type);

        public Pizza OrderPizza(string type) {
            var pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
