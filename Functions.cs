using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Functions
    {
        static void Main(string[] args)
        {
            MathOperations mathOperations = new MathOperations();
            Console.WriteLine("Enter two numbers");

            Console.WriteLine("First number");
            var x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second number");
            var x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Addition: {mathOperations.Addition(x1, x2)} ");
            Console.WriteLine($"Subtraction: {mathOperations.Subtraction(x1, x2)} ");
            Console.WriteLine($"Multiplication: {mathOperations.Multiplication(x1, x2)} ");
            Console.WriteLine($"Division: {mathOperations.Division(x1, x2)} ");
            Console.WriteLine($"Power: {mathOperations.Power(x1, x2)} ");
        }
    }
    public class MathOperations
    {
        public int Addition(int x1, int x2)
        {
            return x1 + x2;
        }

        public int Subtraction(int x1, int x2)
        {
            return x1 - x2;
        }

        public double Multiplication(int x1, int x2)
        {
            return (double)x1 * (double)x2;
        }

        public double Division(int x1, int x2)
        {
            if (!(x1 == 0 || x2 == 0))
            {
                try
                {
                    return (double)x1 / (double)x2;
                }
                // this does not work for some reason so I am just gonna put an if statement above all this
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Attempted to divide by 0");
                    return 0;
                }
            }
            else
            {
                Console.WriteLine("Attempted to divide by 0");
                return 0;
            }
        }

        public double Power(double x1, double x2)
        {
            return Math.Pow((double)x1, (double)x2);
        }
    }
}
