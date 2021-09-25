using System;
using System.Collections.Generic;

namespace CreatingDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> fruits = new Dictionary<string, double>();
            fruits["banana"] = 2.0;
            fruits["apple"] = 1.50;
            fruits["kiwi"] = 3.20;

            foreach (var item in fruits)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            SortedDictionary<string, double> vegetables = new SortedDictionary<string, double>();
            vegetables["tomato"] = 1.20;
            vegetables["potato"] = 0.50;
            vegetables["cucumber"] = 2.3;

            foreach (var item in vegetables)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            // Add (key, value) method:
            Dictionary<string, int> airplanes = new Dictionary<string, int>();
            airplanes.Add("Boeing 737", 130);
            airplanes.Add("Airbus A230", 150);

            // Remove (key) method:
            Dictionary<string, int> planes = new Dictionary<string, int>();
            planes.Add("Boeing 737", 130);
            planes.Remove("Boeing 737");

            // ContainsKey(key) method
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Airbus A320", 150);
            if (dict.ContainsKey("Airbus A320"))
            {
                Console.WriteLine($"Airbus A320 key exists");
            }

            // ContainsValue(value) method
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("Airbus A320", 150);
            Console.WriteLine(dictionary.ContainsValue(150));
        }
    }
}
