using FactoryDemo.PizzaIngredient.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDemo.PizzaIngredient
{
    class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IChesse CreateChesse() {
            return new ReggianoCheese();
        }

        public List<IVeggie> CreateVeggies() {
            return new List<IVeggie> {
                new Mushroom(),
            };
        }

    }
}
