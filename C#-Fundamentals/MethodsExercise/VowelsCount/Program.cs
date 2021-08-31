using System;
using System.Linq;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine().ToLower();

            GetVowels(sentence);
        }

        static void GetVowels(string sentence)
        {
            int vowelsCount = 0;

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < sentence.Length; i++)
            {
                if (vowels.Contains(sentence[i]))
                {
                    vowelsCount++;
                }
            }

            Console.WriteLine(vowelsCount);
        }
    }
}
