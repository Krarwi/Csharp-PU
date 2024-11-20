using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class If_statements
    {
        static void Main(string[] args)
        {
            int age = 16;
            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote, you must be over 18");
            }

        }
    }
}
