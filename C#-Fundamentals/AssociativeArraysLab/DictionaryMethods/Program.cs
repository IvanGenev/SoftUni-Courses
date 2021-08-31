using System;
using System.Collections.Generic;

namespace DictionaryMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> humanWeights = new();

            humanWeights.Add("George", 80);
            humanWeights.Add("Simo", 70);

            foreach (var item in humanWeights)
            {
                Console.WriteLine($"Name: {item.Key} \nWeight: {item.Value}");
            }
        }
    }
}
