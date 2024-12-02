using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Integerarraytask
    {
        static void Main(string[] args)
        {
            int[] number = { 0, 1, 2, 3, 4, 5 };

            int sumofnumbersv = sumofnumbers(number);

            if (sumofnumbersv > -1)
            {
                Console.WriteLine($"The total is {sumofnumbersv}");
                Console.WriteLine(number.Length);
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array");
            }
        }
        static int sumofnumbers(int[] integer)
        {
            return integer.Sum();
        }
    }
}
