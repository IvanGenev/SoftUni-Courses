using System;
using System.Text.RegularExpressions;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex nameRegex = new Regex(@"(?<firstName>[A-Z][a-z]+) (?<lastName>[A-Z][a-z]+)");

            string input = @"John Smith dimitri Pesho Petrov dafadfa Gosho Goshkata sdadadfad";

            MatchCollection fullNames = nameRegex.Matches(input);

            foreach (Match fullName in fullNames)
            {
                Console.WriteLine(fullName.Value);
                Console.WriteLine($"First name -> {fullName.Groups["firstName"]}");
                Console.WriteLine($"Last name -> {fullName.Groups["lastName"]}");
                Console.WriteLine("\n");
            }
        }
    }
}
