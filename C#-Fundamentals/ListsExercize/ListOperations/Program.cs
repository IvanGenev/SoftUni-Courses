using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];

                if (action == "Add")
                {
                    int element = int.Parse(commandArgs[1]);
                    numbers.Add(element);
                }
                else if (action == "Insert")
                {
                    int number = int.Parse(commandArgs[1]);
                    int index = int.Parse(commandArgs[2]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        command = Console.ReadLine();
                        continue;
                    }
                    numbers.Insert(index, number);
                }
                else if (action == "Remove")
                {
                    int index = int.Parse(commandArgs[1]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        command = Console.ReadLine();
                        continue;
                    }

                    numbers.RemoveAt(index);
                }
                else if (commandArgs[1] == "left")
                {
                    int count = int.Parse(commandArgs[2]);

                    for (int i = 0; i < count; i++)
                    {
                        int firstElement = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(firstElement);
                    }

                    //for (int i = 0; i < count; i++)
                    //{
                    //    int firstElement = numbers[0];

                    //    for (int j = 0; j < numbers.Count - 1; j++)
                    //    {
                    //        numbers[j] = numbers[j + 1];
                    //    }

                    //    numbers[numbers.Count - 1] = firstElement;
                    //}
                }
                else if (commandArgs[1] == "right")
                {
                    int count = int.Parse(commandArgs[2]);

                    for (int i = 0; i < count; i++)
                    {
                        int lastElement = numbers[numbers.Count - 1];
                        numbers.RemoveAt(numbers.Count - 1);
                        numbers.Insert(0, lastElement);
                    }

                    //int lastElement = numbers[numbers.Count - 1];

                    //for (int i = numbers.Count - 1; i >= 1; i--)
                    //{
                    //    numbers[i] = numbers[i - 1];
                    //}

                    //numbers[0] = lastElement;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
