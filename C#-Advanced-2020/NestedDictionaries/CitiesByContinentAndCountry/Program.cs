using System;
using System.Collections.Generic;

namespace CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> mainDictionary =
                new Dictionary<string, Dictionary<string, List<string>>>();


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (mainDictionary.ContainsKey(continent) == false)
                {
                    mainDictionary.Add(continent, new Dictionary<string, List<string>>());
                }

                if (mainDictionary[continent].ContainsKey(country) == false)
                {
                    mainDictionary[continent].Add(country, new List<string>());
                }

                mainDictionary[continent][country].Add(city);
            }

            foreach (var continent in mainDictionary)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
