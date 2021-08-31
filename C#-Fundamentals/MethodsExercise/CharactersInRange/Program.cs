using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            PrintCharsInBetween(firstChar, secondChar);
        }

        static void PrintCharsInBetween(char firstChar, char secondChar)
        {
            int startChar = Math.Min(firstChar, secondChar);
            int endChar = Math.Max(firstChar, secondChar);

            for (int i = ++startChar; i < endChar; i++)
                Console.Write((char)i + " ");
            Console.WriteLine();
        }
    }
}
