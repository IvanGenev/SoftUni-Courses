using System;
using System.Text.RegularExpressions;

namespace Match
{
    class Program
    {
        static void Main(string[] args)
        {
            // Match(string text) - Returns the first match of given pattern

            string text = "Genev: 1010";
            var pattern = Regex.Match(text, @"(?<name>[A-Z][a-z]+): (?<number>\d+)");

            Console.WriteLine(pattern.Groups.Count);
            Console.WriteLine("Matched text: \"{0}\"", pattern.Groups[0]);
            Console.WriteLine("Name: {0}", pattern.Groups[1]);
            Console.WriteLine("Number: {0}", pattern.Groups[2]);
        }
    }
}
