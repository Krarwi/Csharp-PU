using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace hatemylife
{
    // UNFINISHED!!!
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            inventory.AddItem("Hotdog", 9.99, 15);
            // inventory.RemoveItem("Hotdog");

            inventory.DisplayItems();
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
            Console.WriteLine("Items");
            foreach (var i in items)
            {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine("Item Details");
            foreach (var i in itemDetails)
            {
                Console.WriteLine(i.ToString());
            }
        }

        public void MostExpensiveItem()
        {

        }
    }
}
