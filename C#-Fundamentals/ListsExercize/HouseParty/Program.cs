using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            List<string> namesGoing = new List<string>();
            string namesNotInList = string.Empty;
            string namesInList = string.Empty;

            for (int i = 0; i < numberOfCommands; i++)
            {
                string command = Console.ReadLine();
                string[] commandArgs = command.Split();
                string name = commandArgs[0];
                string secondSymbol = commandArgs[1];
                string thirdSymbol = commandArgs[2];

                if (thirdSymbol == "not")
                {
                    if (!namesGoing.Contains(name))
                    {
                        namesNotInList = name;
                    }
                    namesGoing.Remove(name);
                }
                else if (thirdSymbol != "not")
                {
                    if (namesGoing.Contains(name))
                    {
                        namesInList = name;
                    }
                    namesGoing.Add(name);
                }
            }


            if (namesNotInList != string.Empty)
            {
                Console.WriteLine($"{namesNotInList} is not in the list!");
            }
            if (namesInList != string.Empty)
            {
                Console.WriteLine($"{namesInList} is already in the list!");
                namesGoing.Remove(namesInList);
            }

            Console.WriteLine(string.Join("\n", namesGoing));
        }
    }
}
