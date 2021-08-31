using System;
using System.Collections.Generic;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, List<string>> namesDictionary = new();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                char startChar = name[0];

                if (!namesDictionary.ContainsKey(startChar))
                {
                    namesDictionary.Add(startChar, new List<string>());
                }

                namesDictionary[startChar].Add(name);

            }

            foreach (var item in namesDictionary)
            {
                Console.Write($"{item.Key} -> ");
                Console.Write(string.Join(", ", item.Value));
                Console.WriteLine();
            }
        }
    }
}
