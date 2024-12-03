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
    internal class Areaofthecircle
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();

            circle.shutthefuckup(1.5);
            double area = circle.CalculateArea();

            Console.WriteLine($"The area of the circle is: {area}");
        }
    }
    public class Circle
    {
        public double Radius { get; set; }
        public double shutthefuckup(double radius)
        {
            return Radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
