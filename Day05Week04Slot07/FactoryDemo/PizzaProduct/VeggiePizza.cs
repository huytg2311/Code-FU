using FactoryDemo.PizzaIngredient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDemo.PizzaProduct
{
    class VeggiePizza : Pizza
    {
        public VeggiePizza(IPizzaIngredientFactory ingredientFactory) : base(ingredientFactory) { 
            
        }

        public override void Prepare() {
            Console.WriteLine("Preparing " + Name);
            Veggies = IngredientFactory.CreateVeggies();
        }
    }
}
