using FactoryDemo.PizzaIngredient.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDemo.PizzaIngredient
{
    class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IChesse CreateChesse()
        {
            return new Mozzarella();
        }

        public List<IVeggie> CreateVeggies()
        {
            return new List<IVeggie> { 
                new Spinach()
        };

        }
    }
}

