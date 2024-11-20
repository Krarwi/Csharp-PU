using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Johnsresults
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter age: ");
            int inputage = Convert.ToInt32(Console.ReadLine());

            int legalage = 18;

            if (inputage >= legalage) 
            {
                Console.WriteLine("You are an adult");
            }
            else  
            {
                Console.WriteLine("You are underage");
            }

            var name = "John";
            Console.WriteLine("Welcome " + name + ", here are the results:");
            int counter = 1;

            while (counter <= 5)
            {
                Console.WriteLine(counter);
                counter += 1;
            }

            switch (counter) 
            {
                case 1:
                    Console.WriteLine(1);
                    break;
                case 2:
                    Console.WriteLine(2);
                    break;
                case 3:
                    Console.WriteLine(3);
                    break;
                case 4:
                    Console.WriteLine(4);
                    break;
                case 5:
                    Console.WriteLine(5);
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }

        }
    }
}
