using System;

namespace Replace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Replace(match, replacement) - replaces all occurrences - the result is a new string

            string text = "Hello, john@softuni.bg, you have been using john@softuni.bg in your registration.";
            string replaceText = text.Replace("john@softuni", "john@softuni.com");

            Console.WriteLine(replaceText);
        }
    }
}
