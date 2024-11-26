using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class ArrayMultiplication
    {
        static void Main(string[] args)
        {
            int num = 7;
            int length = 5;

            int[] intarray = new int[length];

            for (int i = 0; i <= length; i++)
            {
                intarray[i] = num * i;
                i++;
            }
            Console.WriteLine($"Multiplication Table for {num}:");

            foreach (int i in intarray)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
