using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Operators
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 19;
            int num3 = 21;
            int num4 = 18;
            int num5 = 40;
            int num6 = 4;

            Console.WriteLine(num1 += num2);
            Console.WriteLine(num3 *= num4);
            Console.WriteLine(num5 /= num6);

            Console.WriteLine(num6++);
            Console.WriteLine(++num6);
            Console.WriteLine(--num6);
            Console.WriteLine(num6--);

            Console.WriteLine(num5 += num5 -= num1 *= num2 /= num1 %= num5);

        }
    }
}
