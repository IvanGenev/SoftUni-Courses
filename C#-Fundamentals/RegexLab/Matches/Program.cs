using System;
using System.Text.RegularExpressions;

namespace Matches
{
    class Program
    {
        static void Main(string[] args)
        {
            // Matches(string text) - returns a collection of matches

            string text = "Genev: 1010, Ivan: 4826";
            var matches = Regex.Matches(text, @"([A-Z][a-z]+): (\d+)");

            Console.WriteLine("Found {0} matches:\n", matches.Count);

            foreach (Match item in matches)
            {
                Console.WriteLine("Name: {0}", item.Groups[1]);
                Console.WriteLine("Number: {0}", item.Groups[2]);
            }
        }
    }
}
