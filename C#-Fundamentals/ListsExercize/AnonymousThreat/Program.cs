using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {

            // NOT FINISHED

            List<string> names = Console.ReadLine()
                .Split()
                .ToList();

            string command = Console.ReadLine();

            while (command != "3:1")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                int startindex = int.Parse(commandArgs[1]);
                int endIndex = int.Parse(commandArgs[2]);
                string mergedString = string.Empty;

                if (action == "merge")
                {
                    for (int i = startindex; i <= endIndex - 1; i++)
                    {
                        if (startindex < 0 || startindex >= names.Count)
                        {
                            continue;
                        }

                        mergedString += names[startindex];
                        names.RemoveAt(startindex);
                    }

                    names.Insert(startindex, mergedString);
                }

                else if (action == "divide")
                {
                    int index = startindex;
                    int partitions = endIndex;

                    string element = names[index];
                    names.RemoveAt(index);
                    int parts = element.Length / partitions;

                    List<string> dividedElements = new();

                    for (int i = 0; i <= parts; i++)
                    {
                        string currentElement = element.Substring(parts * i, parts);
                        dividedElements.Add(currentElement);
                    }

                    names.InsertRange(index, dividedElements);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", names));
        }
    }
}
