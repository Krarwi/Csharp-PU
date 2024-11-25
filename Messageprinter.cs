using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hatemylife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# is fun, I am going to code C# tomorrow");
            var message = Console.ReadLine();
            Console.WriteLine(message);

            char[] messagearray = message.ToCharArray();
            Array.Reverse(messagearray);

            foreach (char c in message)
            {
                Console.WriteLine(c);
            }
            
            foreach (char c in messagearray)
            {
                Console.WriteLine(c);
            }
        }
    }
}
