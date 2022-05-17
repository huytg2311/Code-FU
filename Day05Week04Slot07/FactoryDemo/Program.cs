using FactoryDemo.PizzaStore;
using System;

namespace FactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaTestDriver();
            Console.ReadKey();
        }
        private static void PizzaTestDriver() {
            var nyStore = new NYStylePizzaStore();
            var pizza = nyStore.OrderPizza("Cheese");
            Console.WriteLine($"You ordered a {pizza.Name}\n");

            var chicago = new ChicagoStylePizzaStore();
            var pizza1 = chicago.OrderPizza("Cheese");
            Console.WriteLine($"You ordered a {pizza1.Name}\n");
        }
    }
}
