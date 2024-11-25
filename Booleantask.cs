using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Booleantask
    {
        static void Main(string[] args)
        {
            int num1 = 15;
            int num2 = 17;
            int num3 = 11;
            int num4 = 15;

            bool isTrue = true;

            bool logicalAND = isTrue && (num1 > num3 && num2 < num4);
            bool logicalOR = isTrue || (num1 < num3 || num2 > num4);
            bool logicalNOT = isTrue;

            Console.WriteLine(logicalAND);
            Console.WriteLine(logicalOR);
            Console.WriteLine(logicalNOT);

            if (num1 > num3)
            {
                Console.WriteLine(num1);
                Console.WriteLine(num3);
            }
            if (num2 < num4)
            {
                Console.WriteLine(num2);
                Console.WriteLine(num4);
            }
            if (num1 == num4)
            {
                Console.WriteLine(num1);
                Console.WriteLine(num4);
            }
            if (num2 != num3)
            {
                Console.WriteLine(num2);
                Console.WriteLine(num3);
            }

            bool expression1 = (num1 > num3 && num2 < num4);
            bool expression2 = (num1 < num3 && num2 > num4);
            Console.WriteLine(expression1);
            Console.WriteLine(expression2);
        }
    }
}
