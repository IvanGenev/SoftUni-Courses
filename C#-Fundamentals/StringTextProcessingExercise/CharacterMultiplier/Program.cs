using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string str1 = input[0];
            string str2 = input[1];

            int minLength = Math.Min(str1.Length, str2.Length);
            int maxLength = Math.Max(str1.Length, str2.Length);

            int sum = 0;

            for (int i = 0; i < minLength; i++)
            {
                sum += MultiplyCharsASCII(str1[i], str2[i]);
            }

            if (str1.Length != str2.Length)
            {
                string longerString = str1.Length > str2.Length ? str1 : str2;

                for (int i = minLength; i < maxLength; i++)
                {
                    sum += longerString[i];
                }
            }

            Console.WriteLine(sum);
        }

        private static int MultiplyCharsASCII(char v1, char v2)
        {
            int multiply = v1 * v2;
            return multiply;
        }
    }
}
