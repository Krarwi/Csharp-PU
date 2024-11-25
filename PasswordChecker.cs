using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class PasswordChecker
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Enter a password: ");
            var password = Console.ReadLine();

            Console.WriteLine("Enter it again please: ");
            var passwordagain = Console.ReadLine();

            foreach (char c in password)
            {
                i += 1;
            }

            if (i < 6)
            {
                Console.WriteLine("Password is too short, please make it atleast 6 characters long");
            }

            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(passwordagain))
            {
                Console.WriteLine("Please enter a password");
            }

            if (password == passwordagain)
            {
                Console.WriteLine("Passwords match");
            }
            else if (password != passwordagain)
            {
                Console.WriteLine("Passwords do not match");
            }

        }
    }
}
