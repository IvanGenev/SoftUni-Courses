using System;

namespace CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());

            string firstString = firstChar.ToString();
            string secondString = secondChar.ToString();
            string thirdString = thirdChar.ToString();

            Console.WriteLine($"{firstString}{secondString}{thirdString}");
        }
    }
}
