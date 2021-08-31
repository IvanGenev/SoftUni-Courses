using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoutCharsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine()
                .Split()
                .ToList();

            if (text.Count > 1)
            {
                Merge(text);
            }

            char[] characters = text[0].ToCharArray();

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (var kvp in characters)
            {
                if (charCount.ContainsKey(kvp))
                {
                    charCount[kvp]++;
                }
                else
                {
                    charCount[kvp] = 1;
                }

            }

            foreach (var kvp in charCount)
            {
                Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
            }
        }

        private static void Merge(List<string> text)
        {
            StringBuilder currentWord = new StringBuilder();

            for (int i = 0; i < text.Count; i++)
            {
                currentWord.Append(text[i]);
            }

            text.RemoveRange(0, text.Count - 1);
            text.Insert(0, currentWord.ToString());

        }
    }
}
