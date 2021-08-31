using System;
using System.Collections.Generic;
using System.Linq;

namespace CountWordsInText
{
    class Program
    {
        static void Main(string[] args)
        {
            //var words = new Dictionary<string, int>();
            //var input = Console.ReadLine().Split();

            //foreach (var word in input)
            //{
            //    if (words.ContainsKey(word))
            //        words[word]++;
            //    else
            //        words[word] = 1;
            //}

            //words = words.OrderByDescending(item => item.Value)
            //    .ToDictionary(item => item.Key, item => item.Value);

            //foreach (var word in words)
            //{
            //    Console.WriteLine($"{word.Key} -> {word.Value}");
            //}

            var fruits = new Dictionary<string, double>();
            fruits.Add("Banana", 2.20);
            fruits.Add("Kiwi", 4.50);
            fruits.Add("Apple", 2.50);

            fruits = fruits.OrderByDescending(item => item.Value)
                .ToDictionary(item => item.Key, item => item.Value);

            foreach (var fruit in fruits)
            {
                Console.WriteLine($"{fruit.Key} -> {fruit.Value}");
            }
        }
    }
}
