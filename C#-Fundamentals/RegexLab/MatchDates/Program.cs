using System;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //MatchCollection dateMatches = Regex.Matches(input, @"[0-9]{2}(?<separator>.)[A-Z][a-z]{2}\k<separator>[0-9]{4}");

            var dateMatches = Regex.Matches(input, @"(?<day>[0-9]{2})(?<separator>.)(?<month>[A-Z][a-z]{2})\k<separator>(?<year>[0-9]{4})");

            foreach (Match match in dateMatches)
            {
                Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
            }
        }
    }
}
