using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"(U\$)([A-Z][a-z]{2,})\1(P@\$)([a-z]{5,}[0-9]{1,})\3";

            Regex regex = new Regex(pattern);

            int successfulRegistrationsCount = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                var matches = regex.Matches(input);
                var validInput = regex.IsMatch(input);

                if (validInput)
                {
                    Console.WriteLine("Registration was successful");

                    foreach (Match match in matches)
                    {
                        Console.WriteLine($"Username: {match.Groups[2]}, Password: {match.Groups[4]}");
                    }

                    successfulRegistrationsCount++;
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }

            Console.WriteLine($"Successful registrations: {successfulRegistrationsCount}");
        }
    }
}
