using DemoDatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace DemoDatabaseFirst
{
    class Program
    {
        //static void FilteredIncludes() {
        //    using var db = new MyStoreContext();
        //    Console.WriteLine("Enter a minimum for units in stock: ");
        //    string unitsInStock = Console.ReadLine();
        //    int stock = int.Parse(unitsInStock);
        //    IQueryable<Category> cats = db.Categories
        //        .Include(c => c.Products.Where(p => p.UnitsInStock >= stock));
        //    foreach (Category c in cats) {
        //        Console.WriteLine($"{c.CategoryName} has {c.Products.Count} product");
        //        foreach (Product p in c.Products) {
        //            Console.WriteLine($"--->{p.ProductName} has {p.UnitsInStock} units in stock");
        //        }
        //    }

        //static void AggregateProducts() {
        //    using (var db = new MyStoreContext()) {
        //        Console.WriteLine("{0, -25} {1, 10}", arg0: "Product count:", arg1: db.Products.Count());
        //        Console.WriteLine("{0, -25} {1, 10:$#,##0.00}", arg0: "Highest product price:", arg1: db.Products.Max(p => p.UnitPrice));
        //        Console.WriteLine("{0, -25} {1, 10:N0}", arg0: "Sum of units in stock:", arg1: db.Products.Sum(p => p.UnitsInStock));
        //        Console.WriteLine("{0, -25} {1, 10:$#,##0.00}", arg0: "Average unit price:", arg1: db.Products.Average(p => p.UnitPrice));
        //        Console.WriteLine("{0, -25} {1, 10:$#,##0.00}", arg0: "Value of units in stock", arg1: db.Products.AsEnumerable().Sum(p => p.UnitPrice * p.UnitsInStock));
        //    }
        //}

        static void QueryingProducts() {
            using (var db = new MyStoreContext()) {
                Console.WriteLine("Products that cost more than a price, highest at top");
                string input;
                decimal price;
                do
                {
                    Console.WriteLine("Enter a product price: ");
                    input = Console.ReadLine();
                } while (!decimal.TryParse(input, out price));
                IQueryable<Product> prods = db.Products
                    .Where(product => product.UnitPrice > price)
                    .OrderByDescending(product => product.UnitPrice);
                foreach (Product item in prods) {
                    Console.WriteLine($"ProductName: {item.ProductName} costs {item.UnitPrice:$#,##0.00} " + $"and has {item.UnitsInStock} in stock.");
                }
                { 
                
                }
            }
        }
        
        static void Main(string[] args)
        {
            //// create a db-context object
            //MyStoreContext myStore = new MyStoreContext();
            //// print all products
            //var products = from p in myStore.Products
            //               select new { p.ProductName, p.CategoryId };
            //foreach (var p in products) {
            //    Console.WriteLine($"ProductName: {p.ProductName}, CategoryID: {p.CategoryId}");
            //}
            //Console.WriteLine("---------------------------------");
            //// query all categories
            //IQueryable<Category> cats = myStore.Categories.Include(c => c.Products);
            //foreach (Category c in cats) {
            //    Console.WriteLine($"CategoryID: {c.CategoryId} has {c.Products.Count} products.");
            //}
            //Console.ReadLine();

            //FilteredIncludes();
            //Console.ReadLine();

            //AggregateProducts();
            //Console.ReadLine();

            QueryingProducts();
            Console.ReadLine();
        }
    }
}
