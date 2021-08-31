using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main()
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxPassengers = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArgs = command.Split();

                if (commandArgs[0] == "Add")
                {
                    int passengers = int.Parse(commandArgs[1]);
                    wagons.Add(passengers);
                }
                else
                {
                    int passengers = int.Parse(commandArgs[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= maxPassengers)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
