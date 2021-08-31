using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main()
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];

                int element = int.Parse(commandArgs[1]);

                if (action == "Delete")
                {
                    input.RemoveAll(item => item == element);
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(commandArgs[2]);
                    input.Insert(index, element);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
