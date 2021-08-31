using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    class Program
    {
        static void Main()
        {
            List<int> originalList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            List<int> amendedList = new();


            while (command != "end")
            {
                List<int> evenNumbers = new();
                List<int> oddNumbers = new();
                List<int> lessThan = new();
                List<int> moreThan = new();
                List<int> lessOrEqual = new();
                List<int> moreOrEqual = new();

                string[] commandArgs = command.Split();
                string action = commandArgs[0];
                int element = 0;
                string condition = " ";
                int number = 0;

                if (commandArgs.Length > 1 && commandArgs.Length <= 2)
                {
                    element = int.Parse(commandArgs[1]);

                }
                else if (commandArgs.Length > 2)
                {
                    condition = commandArgs[1];
                    number = int.Parse(commandArgs[2]);
                }

                if (action == "Add")
                {
                    originalList.Add(element);
                    amendedList = originalList;
                }
                else if (action == "Remove")
                {
                    amendedList.Remove(element);
                }
                else if (action == "RemoveAt")
                {
                    amendedList.RemoveAt(element);
                }
                else if (action == "Insert")
                {
                    int index = int.Parse(commandArgs[2]);
                    amendedList.Insert(index, element);
                }

                else if (action == "PrintEven")
                {
                    foreach (var item in amendedList)
                    {
                        if (item % 2 == 0)
                        {
                            evenNumbers.Add(item);
                        }
                    }

                    Console.WriteLine(string.Join(" ", amendedList));
                }
                else if (action == "PrintOdd")
                {
                    foreach (var item in amendedList)
                    {
                        if (item % 2 != 0)
                        {
                            oddNumbers.Add(item);
                        }
                    }

                    Console.WriteLine(string.Join(" ", oddNumbers));
                }
                else if (action == "Contains")
                {
                    if (amendedList.Contains(element))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (action == "GetSum")
                {
                    int sum = 0;
                    foreach (var item in amendedList)
                    {
                        sum += item;
                    }
                    Console.WriteLine(sum);
                }
                else if (action == "Filter")
                {
                    if (condition == "<")
                    {
                        foreach (var item in amendedList)
                        {
                            if (item < number)
                            {
                                lessThan.Add(item);
                            }
                        }

                        Console.WriteLine(string.Join(" ", lessThan));
                    }
                    else if (condition == ">")
                    {
                        foreach (var item in amendedList)
                        {
                            if (item > number)
                            {
                                moreThan.Add(item);
                            }
                        }

                        Console.WriteLine(string.Join(" ", moreThan));
                    }
                    else if (condition == "<=")
                    {
                        foreach (var item in amendedList)
                        {
                            if (item <= number)
                            {
                                lessOrEqual.Add(item);
                            }
                        }

                        Console.WriteLine(string.Join(" ", lessOrEqual));
                    }
                    else if (condition == ">=")
                    {
                        foreach (var item in amendedList)
                        {
                            if (item >= number)
                            {
                                moreOrEqual.Add(item);
                            }
                        }

                        Console.WriteLine(string.Join(" ", moreOrEqual));
                    }
                }

                command = Console.ReadLine();
            }


            if (string.Join(" ", amendedList) != string.Join(" ", originalList))
            {
                Console.WriteLine(string.Join(" ", amendedList));
            }
        }
    }
}
