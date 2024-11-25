using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Switch
    {
        static void Main(string[] args)
        {
            int Grade = 4;
            switch (Grade)
            {
                case 0: 
                    Console.WriteLine("Fail");
                    break;
                case 1: 
                    Console.WriteLine("Needs Improvement");
                    break;
                case 2: 
                    Console.WriteLine("Ok");
                    break;
                case 3: 
                    Console.WriteLine("Satisfactory");
                    break;
                case 4: 
                    Console.WriteLine("Good");
                    break;
                case 5: 
                    Console.WriteLine("Excellent");
                    break;
            }
        }
    }
}
