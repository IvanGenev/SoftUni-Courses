using System;
using System.Text.RegularExpressions;

namespace IsMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // IsMatch(string text) - Determines whether the text matches given pattern

            string text = "Today is 2015-05-11";
            string pattern = @"\d{4}-\d{2}-\d{2}";

            var regex = Regex.IsMatch(text, @"\d{4}-\d{2}-\d{2}");

            Console.WriteLine(regex);
        }
    }
}
