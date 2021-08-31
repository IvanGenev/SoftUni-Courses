using System;

namespace PringMiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string output = string.Empty;

            if (input.Length % 2 == 0)
            {
                output = GetMiddleCharFromEvenStingLenght(input);
                Console.WriteLine(output);
            }
            else
            {
                output = GetMiddleCharFromOddStingLenght(input);
                Console.WriteLine(output);
            }
        }

        private static string GetMiddleCharFromOddStingLenght(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index, 1);

            return chars;
        }

        private static string GetMiddleCharFromEvenStingLenght(string input)
        {
            int index = input.Length / 2;
            string chars = input.Substring(index -1, 2);

            return chars;
        }
    }
}
