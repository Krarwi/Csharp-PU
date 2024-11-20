using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class Loop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many times do you want to loop");
            int loop = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= loop; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("The loop has finished");
        }
    }
}
