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
    internal class ExepctionHandlingTask
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Enter two integers for division");

            Console.WriteLine("Enter numerator:");
            var x1 = Console.ReadLine();
            Console.WriteLine("Enter denominator:");
            var x2 = Console.ReadLine();
            int x1rev = calculator.ParseInput(x1);
            int x2rev = calculator.ParseInput(x2);

            double result = calculator.Divide(x1rev, x2rev);
            Console.WriteLine($"Result: {result}");
        }
    }
    public class Calculator
    {
        public double Divide(int x1, int x2)
        {
            try
            {
                return (double)x1 / (double)x2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(0.0);
                return 0.0;
            }
        }
        public int ParseInput(string input)
        {
            try
            {
                return Convert.ToInt32(input);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return -1;
            }
        }
    }
}
