using System;

namespace VowelsCount
{
    class Program
    {
        public static int PrintVowels(string input)
        {
            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar == 'a')
                {
                    counter++;
                }
                else if (currentChar == 'e')
                {
                    counter++;
                }
                else if (currentChar == 'i')
                {
                    counter++;
                }
                else if (currentChar == 'o')
                {
                    counter++;
                }
                else if (currentChar == 'u')
                {
                    counter++;
                }
                else if (currentChar == 'y')
                {
                    counter++;
                }
            }

            return counter;

        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            int result = PrintVowels(input);

            Console.WriteLine(result);
        }
    }
}
