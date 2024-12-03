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
    internal class Logicalerror3
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]{ 1, 2, 3, 4, 5 };
            int sum = 0;

            foreach (int i in numbers)
            {
                sum += i;
            }
            Console.WriteLine($"Sum of numbers: {sum}");
        }
    }
}
