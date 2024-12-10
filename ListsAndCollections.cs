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
    internal class ListsAndCollections
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            inventory.AddItem("Laptop", 1200.50, 7);
            inventory.AddItem("Smartphone", 799.99, 12);
            inventory.AddItem("Tablet", 399.99, 15);

            inventory.DisplayItems();

            inventory.UpdateItem("Laptop", 1200.50, 5);
            inventory.RemoveItem("Tablet");

            inventory.MostExpensiveItem();

            inventory.TotalInventoryValue();
        }
    }
    public class Inventory
    {
        private List<string> items = new List<string>();
        private Dictionary<(double price, int stock), string> itemDetails = new Dictionary<(double price, int stock), string>();

        public void AddItem(string name, double price, int stock)
        {
            items.Add(name);
            itemDetails.Add((price, stock), name);
        }

        public void RemoveItem(string name)
        {

            if (items.Remove(name))
            {
                var keysToRemove = new List<(double price, int stock)>();
                foreach (var entry in itemDetails)
                {
                    if (entry.Value == name)
                    {
                        keysToRemove.Add(entry.Key);
                    }
                }

                foreach (var key in keysToRemove)
                {
                    itemDetails.Remove(key);
                }
            }
            else
            {
                Console.WriteLine($"Item {name} not found");
            }
        }

        public void UpdateItem(string name, double price, int stock)
        {
            if (items.Remove(name))
            {
                var keysToRemove = new List<(double price, int stock)>();
                foreach (var entry in itemDetails)
                {
                    if (entry.Value == name)
                    {
                        keysToRemove.Add(entry.Key);
                    }
                }

                foreach (var key in keysToRemove)
                {
                    itemDetails.Remove(key);
                }

                items.Add(name);
                itemDetails.Add((price, stock), name);
            }
        }

        public void DisplayItems()
        {
            Console.WriteLine("// Items //");
            foreach (var item in items)
            {
                var details = itemDetails.FirstOrDefault(x => x.Value == item);
                Console.WriteLine($" {item,-10} // {details.Key.price,7} // {details.Key.stock,5} //");
            }
        }

        public void MostExpensiveItem()
        {
            if (itemDetails.Count == 0)
            {
                Console.WriteLine("No items in inventory.");
                return;
            }

            var mostExpensive = itemDetails.OrderByDescending(entry => entry.Key.price).First();

            Console.WriteLine($"Most Expensive Item: {mostExpensive.Value}, Price: {mostExpensive.Key.price}, Stock: {mostExpensive.Key.stock}");
        }
        public void TotalInventoryValue()
        {
            if (itemDetails.Count == 0)
            {
                Console.WriteLine("No items in inventory.");
                return;
            }

            double price = itemDetails.Keys.Sum(k => k.price);
            int stock = itemDetails.Keys.Sum(k => k.stock);
            Console.WriteLine($"Total value of the inventory is: {price * stock}");
        }
    }
}
