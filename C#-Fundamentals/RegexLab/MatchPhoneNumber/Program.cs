using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var matchPhone = Regex.Matches(input, @"( ?\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b");

            var validPhone = matchPhone
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", validPhone));
        }
    }
}
