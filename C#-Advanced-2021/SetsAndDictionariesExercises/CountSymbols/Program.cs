using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            SortedDictionary<char, int> charDictionary = new SortedDictionary<char, int>();

            foreach (var item in input)
            {
                if (!charDictionary.ContainsKey(item))
                {
                    charDictionary.Add(item, 0);
                }

                charDictionary[item]++;
            }

            foreach (var item in charDictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
