using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            string[] wordLines = File.ReadAllLines("words.txt");

            string[] textLines = File.ReadAllLines("text.txt");

            foreach (var item in wordLines)
            {
                if (!wordsCount.ContainsKey(item))
                {
                    wordsCount.Add(item, 0);
                }
            }

            foreach (var line in textLines)
            {
                foreach (var word in wordsCount)
                {
                    if (line.Contains(word.Key, StringComparison.OrdinalIgnoreCase))
                    {
                        wordsCount[word.Key]++;
                    }
                }
            }

            foreach (var item in wordsCount.OrderByDescending(x => x.Value))
            {
                string result = $"{item.Key} - {item.Value}{Environment.NewLine}";

                File.AppendAllText("actualResult.txt", result);
            }
        }
    }
}
