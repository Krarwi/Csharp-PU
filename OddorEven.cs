using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class OddorEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0) 
            {
                Console.WriteLine($"The Number {number} is even");
            }
            else
            {
                Console.WriteLine($"The Number {number} is odd");
            }
        }
    }
}
