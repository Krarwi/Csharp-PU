using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Arraystuff
    {
        static void Main(string[] args)
        {
            int[] inarray = new int[] 
            { 
                45, 12, 78, 34, 89, 23, 
            };

            foreach (int i in inarray)
            {
                Console.Write($"{i} ");
            }

            Array.Sort(inarray);

            Console.WriteLine();

            foreach (int i in inarray)
            {
                Console.Write($"{i} ");
            }

            Array.Reverse(inarray);

            Console.WriteLine();

            foreach (int i in inarray)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            inarray = inarray.Where(val => val != 78).ToArray();

            foreach (int i in inarray)
            {
                Console.Write($"{i} ");
            }

            if (inarray.Contains(34))
            {
                Console.WriteLine("The number does not exist");
            }
        }
    }
}
