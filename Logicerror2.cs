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
    internal class Logicerror2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (18 <= age && age <= 29)
            {
                Console.WriteLine("Over 18");
            }
            else if (30 <= age && age <= 49)
            {
                Console.WriteLine("Over 30");
            }
            else if (50 <= age)
            {
                Console.WriteLine("Over 50");
            }
            else if (age <= 17)
            {
                Console.WriteLine("Under 18");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
