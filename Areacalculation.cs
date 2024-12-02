using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Areacalculation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the width of your triangle");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the length of your triangle");
            int length = Convert.ToInt32(Console.ReadLine());

            int answer = formula(width, length);

            Console.WriteLine($"Calculated area of the triangle: {answer}");

        }
        static int formula(int width, int length)
        {
            return width * length / 2;
        }
    }
}
