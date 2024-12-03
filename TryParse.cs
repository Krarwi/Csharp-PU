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
    internal class TryParse
    {
        static void Main(string[] args)
        {
            string funnier = "funny";
            string notfunny = "3";

            try
            {
                Int32.Parse(funnier);
                Console.WriteLine(funnier);
                Console.WriteLine("Conversion succeded!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Conversion Failed");
            }
        }
    }
}
