using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    internal class DictionaryCaseTask
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> subjectteachers = new Dictionary<string, string>();

            while (true)
            {
                Console.WriteLine("1. Add a new subject");
                Console.WriteLine("2. Remove a subject");
                Console.WriteLine("3. Display all subjects and their teachers");
                Console.WriteLine("4. Exit");

                int answer = Convert.ToInt32(Console.ReadLine());

                switch (answer)
                {
                    case 1:
                        Console.WriteLine("Enter the name of the new subject");
                        string newsubject = Console.ReadLine();

                        Console.WriteLine("Enter the teachers name for this subject");
                        string newteacher = Console.ReadLine();

                        subjectteachers.Add(newsubject, newteacher);

                        Console.WriteLine($"You have successfully created the new subject {newsubject} and assigned it to the teacher {newteacher}");
                        break;
                    case 2:
                        Console.WriteLine("Enter the name of the subject you wish to remove");

                        string removesubject = Console.ReadLine();

                        if (subjectteachers.ContainsKey(removesubject))
                        {
                            subjectteachers.Remove(removesubject);
                            Console.WriteLine($"Successfully removed subject {removesubject}");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR, could not find subject {removesubject}");
                        }
                        break;
                    case 3:
                        foreach (var item in subjectteachers)
                        {
                            Console.WriteLine($"{item.Key} - {item.Value}");
                        }
                        break;
                    case 4:
                        System.Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
