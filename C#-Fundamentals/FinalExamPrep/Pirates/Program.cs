using System;
using System.Collections.Generic;
using System.Linq;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("||");

            Dictionary<string, List<int>> cities = new Dictionary<string, List<int>>();

            while (input[0] != "Sail")
            {
                string cityName = input[0];
                int cityPopulation = int.Parse(input[1]);
                int cityGold = int.Parse(input[2]);

                if (!cities.ContainsKey(cityName))
                {
                    cities.Add(cityName, new List<int>() { cityPopulation, cityGold });
                }
                else
                {
                    cities[cityName][0] += cityPopulation;
                    cities[cityName][1] += cityGold;
                }

                input = Console.ReadLine().Split("||");
            }

            string[] command = Console.ReadLine().Split("=>");

            while (command[0] != "End")
            {
                if (command[0] == "Plunder")
                {
                    cities = PlunderCity(cities, command[1], int.Parse(command[2]), int.Parse(command[3]));
                }
                else
                {
                    cities = ProsperCity(cities, command[1], int.Parse(command[2]));
                }

                command = Console.ReadLine().Split("=>");
            }

            cities = cities
                .OrderByDescending(x => x.Value[1])
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (var city in cities)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }

        static Dictionary<string, List<int>> ProsperCity(Dictionary<string, List<int>> cities, string town, int gold)
        {
            if (gold < 0)
            {
                Console.WriteLine("Gold added cannot be a negative number!");
            }
            else
            {
                cities[town][1] += gold;

                Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town][1]} gold.");
            }

            return cities;
        }

        static Dictionary<string, List<int>> PlunderCity(Dictionary<string, List<int>> cities, string town, int people, int gold)
        {
            cities[town][0] -= people;
            cities[town][1] -= gold;

            Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

            if (cities[town][0] <= 0 || cities[town][1] <= 0)
            {
                cities.Remove(town);
                Console.WriteLine($"{town} has been wiped off the map!");
            }

            return cities;
        }
    }
}
