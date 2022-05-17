using FactoryDemo.PizzaIngredient;
using FactoryDemo.PizzaProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDemo.PizzaStore
{
    class ChicagoStylePizzaStore : PizzaStore
    {
        private readonly ChicagoPizzaIngredientFactory _ingredientFactory;

        public ChicagoStylePizzaStore() {
            _ingredientFactory = new ChicagoPizzaIngredientFactory();
        }

        protected override Pizza CreatePizza(string type) {
            Pizza pizza;

            switch (type) {
                case "Cheese":
                    pizza = new CheesePizza(_ingredientFactory);
                    pizza.SetName("Chicago Style Cheese Pizza");
                    break;
                case "Veggie":
                    pizza = new VeggiePizza(_ingredientFactory);
                    pizza.SetName("Chicago Style Veggie Pizza");
                    break;
                default:
                    return null;
            }
            return pizza;
        }

    }
}
