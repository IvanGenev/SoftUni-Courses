using System;
using System.Collections.Generic;
using System.Linq;

namespace SandBox2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(", ")
                .ToList();

            List<string> blackListed = new();
            List<string> lostName = new();

            string command = Console.ReadLine();

            while (command != "Report")
            {
                string[] commandArgs = command.Split();

                if (commandArgs[0] == "Blacklist")
                {
                    if (names.Contains(commandArgs[1]))
                    {
                        blackListed.Add(commandArgs[1]);
                        Console.WriteLine("{0} was blacklisted.", commandArgs[1]);

                        for (int i = 0; i < names.Count; i++)
                        {
                            if (names[i].Contains(commandArgs[1]))
                            {
                                names.Insert(i, "Blacklisted");
                                break;
                            }
                        }
                        names.Remove(commandArgs[1]);
                    }
                    else
                    {
                        Console.WriteLine("{0} was not found.", commandArgs[1]);
                    }
                }

                else if (commandArgs[0] == "Error")
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (int.Parse(commandArgs[1]) > 0 && int.Parse(commandArgs[1]) <= names.Count - 1)
                        {
                            if (names.Contains(names[i]) && !names.Contains("Lost"))
                            {
                                lostName.Add(names[int.Parse(commandArgs[1])]);
                                Console.WriteLine("{0} was lost due to an error.", names[int.Parse(commandArgs[1])]);
                                names.RemoveAt(int.Parse(commandArgs[1]));
                                names.Insert(int.Parse(commandArgs[1]), "Lost");
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                else if (commandArgs[0] == "Change")
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (int.Parse(commandArgs[1]) <= names.Count - 1)
                        {
                            Console.WriteLine("{0} changed his username to {1}", names[int.Parse(commandArgs[1])], commandArgs[2]);
                            names.RemoveAt(int.Parse(commandArgs[1]));
                            names.Insert(int.Parse(commandArgs[1]), commandArgs[2]);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Blacklisted names: {0}", blackListed.Count);
            Console.WriteLine("Lost names: {0}", lostName.Count);
            Console.WriteLine(string.Join(" ", names));
        }
    }
}
