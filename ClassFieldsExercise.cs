using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class ClassFieldsExercise
    {
        static void Main(string[] args)
        {
            Product product = new Product();

            product.AddProduct("Phone", 599, 5);
            product.AddProduct("Laptop", 999.99, 10);

            product.DisplayInventory();
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        private Dictionary<string, Product> products = new Dictionary<string, Product>();

        public void AddProduct(string x, double z, int o)
        {
            Product product = new Product();

            product.Name = x;
            product.Price = z;
            product.Stock = o;

            products.Add(product.Name, product);
        }

        public void DisplayInventory()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("Your inventory is empty");
            }
            else
            {
                foreach (var product in products.Values)
                {
                    Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Stock: {product.Stock}");
                }
            }
        }
    }
}
