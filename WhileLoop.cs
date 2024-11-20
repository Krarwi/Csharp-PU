using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class WhileLoop
    {
        static void Main(string[] args)
        {
            int counter = 1;
            while (counter <= 5) {
                Console.WriteLine(counter);
                counter += 1;
            }
            Console.WriteLine("The loop has finished");
        }
    }
}
