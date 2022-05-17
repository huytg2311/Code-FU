using FactoryDemo.PizzaIngredient;
using FactoryDemo.PizzaIngredient.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDemo.PizzaProduct
{
    public abstract class Pizza
    {
        public string Name { get; protected set; }
        public List<IVeggie> Veggies { get; set; }
        public IChesse Chesse { get; protected set; }
        protected readonly IPizzaIngredientFactory IngredientFactory;
        protected Pizza(IPizzaIngredientFactory ingredientFactory) { 
            IngredientFactory = ingredientFactory;
        }
        public abstract void Prepare();

        public void Bake() {
            Console.WriteLine("Bake for 25 minutes at 350 degree");
        }

        public void Cut() {
            Console.WriteLine("Cutting the pizza into diagonal slices.");
        }

        public void Box() {
            Console.WriteLine("Place pizza in official PizzaStore box.");
        }

        public void SetName(string name) {
            Name = name;
        }
    }
}
