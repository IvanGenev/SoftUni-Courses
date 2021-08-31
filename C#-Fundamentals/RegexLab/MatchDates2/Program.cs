using System;
using System.Text.RegularExpressions;

namespace MatchDates2
{
    class Program
    {
        static void Main(string[] args)
        {
            var validDates = Regex.Matches(Console.ReadLine(), @"\b(?<day>\d{2})(?<separator>[-.\/])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>\d{4})\b");

            foreach (Match date in validDates)
            {
                Console.WriteLine($"Day: {date.Groups["day"].Value}, " +
                    $"Month: {date.Groups["month"].Value}, " +
                    $"Year: {date.Groups["year"].Value}");
            }
        }
    }
}
