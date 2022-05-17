using FactoryDemo.PizzaIngredient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDemo.PizzaProduct
{
    class CheesePizza : Pizza
    {
        public CheesePizza(IPizzaIngredientFactory ingredientFactory) : base(ingredientFactory) {

        }

        public override void Prepare() {
            Console.WriteLine("Preparing " + Name);
            Chesse = IngredientFactory.CreateChesse();
        }
    }
}
