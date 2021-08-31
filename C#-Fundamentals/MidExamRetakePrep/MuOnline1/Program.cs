using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SandBox
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

            while (!command.Contains("END"))
            {
                string[] commandArgs = command.Split();
                string commandName = commandArgs[0];

                //string justNumbers = new String(textIN.Where(Char.IsDigit).ToArray());

                int[] justNumbers = Regex.Matches(command, "(-?[0-9]+)").OfType<Match>().Select(m => int.Parse(m.Value)).ToArray();

                if (commandName == "add")
                {
                    string commandAction = commandArgs[2];

                    if (commandAction == "start")
                    {
                        numbers.InsertRange(0, justNumbers);
                    }
                    else if (commandAction == "end")
                    {
                        foreach (var item in justNumbers)
                        {
                            numbers.Add(item);
                        }
                    }
                }

                if (commandName == "remove")
                {
                    string commandAction = commandArgs[1];

                    if (commandAction == "lower")
                    {
                        int value = int.Parse(commandArgs[3]);
                        numbers.RemoveAll(s => s < value);
                    }
                    else if (commandAction == "greater")
                    {
                        int value = int.Parse(commandArgs[3]);
                        numbers.RemoveAll(s => s > value);
                    }

                    if (commandArgs[2] == "index")
                    {
                        int index = int.Parse(commandArgs[3]);

                        if (index >= 0)
                        {
                            numbers.RemoveAt(index);
                        }
                    }

                    if (commandArgs[1] == "count")
                    {
                        int count = int.Parse(commandArgs[2]);

                        if (numbers.Count < count)
                        {
                            numbers.Clear();
                            return;
                        }

                        numbers.Reverse();

                        for (int i = 0; i < count; i++)
                        {
                            numbers.RemoveAt(0);
                        }

                        numbers.Reverse();
                    }
                }

                if (commandName == "replace")
                {
                    int oldValue = int.Parse(commandArgs[1]);
                    int newValue = int.Parse(commandArgs[2]);

                    int index = numbers.IndexOf(oldValue);

                    if (index >= 0)
                    {
                        numbers.RemoveAt(index);
                        numbers.Insert(index, newValue);
                    }
                }

                if (commandName == "find")
                {
                    string evenOdd = commandArgs[1];

                    if (evenOdd == "even")
                    {
                        foreach (var item in numbers)
                        {
                            if (item % 2 == 0)
                            {
                                Console.Write(item + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (evenOdd == "odd")
                    {
                        foreach (var item in numbers)
                        {
                            if (item % 2 != 0)
                            {
                                Console.Write(item + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
