using System;
using System.Text.RegularExpressions;

namespace Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Replace(string text, string replacement text) - replaces all strings that match the pattern with the provided replacement

            string text = "Ivan: 1010, Genev: 1001";
            string pattern = @"\d{4}";
            string replacement = "101010";
            Regex regex = new Regex(pattern);
            string result = regex.Replace(text, replacement);

            Console.WriteLine(result);
        }
    }
}
