using System;
using System.Text.RegularExpressions;

namespace EmojiDetector2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"([:*])\1([A-Z[a-z]{2,})\1{2}");

            long coolThreshold = 1;

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    coolThreshold *= input[i]
                }
            }
        }
    }
}
