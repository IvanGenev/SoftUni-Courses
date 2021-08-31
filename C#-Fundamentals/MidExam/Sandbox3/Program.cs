using System;
using System.Collections.Generic;
using System.Linq;

namespace Sandbox3
{
    class Program
    {
        static void Main()
        {
            List<string> cardsDeck = Console.ReadLine()
                .Split(":")
                .ToList();

            List<string> cardHand = new();

            string command = Console.ReadLine();

            while (command != "Ready")
            {
                string[] commandArgs = command.Split();

                if (commandArgs[0] == "Add")
                {
                    if (cardsDeck.Contains(commandArgs[1]))
                    {
                        cardHand.Add(commandArgs[1]);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (commandArgs[0] == "Insert")
                {
                    if (cardsDeck.Contains(commandArgs[1]))
                    {
                        cardHand.Insert(int.Parse(commandArgs[2]), commandArgs[1]);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }
                else if (commandArgs[0] == "Remove")
                {
                    if (cardsDeck.Contains(commandArgs[1]))
                    {
                        cardHand.Remove(commandArgs[1]);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (commandArgs[0] == "Swap")
                {

                    for (int i = 0; i < cardHand.Count; i++)
                    {

                        if (cardHand[i].Contains(commandArgs[1]))
                        {
                            cardHand.Insert(i, commandArgs[2]);
                            break;
                        }

                    }
                        cardHand.RemoveAt(2);
                }
                else if (commandArgs[0] == "Shuffle")
                {
                    cardHand.Reverse();
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", cardHand));
        }
    }
}
