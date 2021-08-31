using System;
using System.Text.RegularExpressions;

namespace MatchAFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Regex.Matches(Console.ReadLine(), @"\b[A-Z][a-z]+ [A-Z][a-z]+");

            Console.WriteLine();

            foreach (Match name in names)
            {
                Console.WriteLine($"{name.Value}\n");
            }

        }
    }
}
