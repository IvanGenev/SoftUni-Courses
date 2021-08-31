using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>();

            string input = Console.ReadLine();
            string currentItem = string.Empty;
            bool isOdd = true;

            while (input != "stop")
            {
                if (isOdd)
                {
                    if (!items.ContainsKey(input))
                    {
                        items.Add(input, 0);
                    }
                    currentItem = input;

                    isOdd = false;
                }
                else
                {
                    int value = int.Parse(input);
                    items[currentItem] += value;
                    isOdd = true;
                }
                input = Console.ReadLine();
            }

            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
