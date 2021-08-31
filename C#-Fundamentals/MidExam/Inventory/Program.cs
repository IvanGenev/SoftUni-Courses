using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine()
                .Split(", ")
                .ToList();

            string command = Console.ReadLine();
            
            while (command != "Craft!")
            {
                string[] commandArgs = command.Split(" - ");

                if (commandArgs[0] == "Collect")
                {
                    if (!journal.Contains(commandArgs[1]))
                    {
                        journal.Add(commandArgs[1]);
                    }
                }
                else if (commandArgs[0] == "Drop" && journal.Contains(commandArgs[1]))
                {
                    journal.Remove(commandArgs[1]);
                }
                else if (commandArgs[0] == "Combine Items")
                {
                    string[] splitItems = commandArgs[1].Split(":");

                    int index = journal.IndexOf(splitItems[0]);

                    if (index >= 0)
                    {
                        journal.Insert(index + 1, splitItems[1]);
                    }
                }
                else if (commandArgs[0] == "Renew")
                {
                    if (journal.Remove(commandArgs[1]))
                    {
                        journal.Add(commandArgs[1]);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", journal));
        }
    }
}
