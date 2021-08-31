using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split("!").ToList();

            string input = Console.ReadLine();

            while (input != "Go Shopping!")
            {
                string[] commandArgs = input.Split();
                string command = commandArgs[0];
                string item = commandArgs[1];

                if (command == "Urgent")
                {
                    if (!groceries.Contains(item))
                    {
                        groceries.Insert(0, item);
                    }
                }
                else if (command == "Unnecessary")
                {
                    if (groceries.Contains(item))
                    {
                        groceries.Remove(item);
                    }
                }
                else if (command == "Correct")
                {
                    string newItem = commandArgs[2];
                    int index = groceries.IndexOf(item);

                    if (groceries.Contains(item))
                    {
                        groceries.Insert(index, newItem);
                        groceries.Remove(item);
                    }
                }
                else if (command == "Rearrange")
                {
                    if (groceries.Contains(item))
                    {
                        groceries.Remove(item);
                        groceries.Add(item);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
