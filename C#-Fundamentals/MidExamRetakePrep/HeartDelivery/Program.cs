using System;
using System.Collections.Generic;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberOfHearts = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();
            int currentPosition = 0;

            while (input != "Love!")
            {
                List<string> inputArgs = input.Split().ToList();

                if (inputArgs[0] == "Jump")
                {
                    currentPosition += int.Parse(inputArgs[1]);
                }
                
                if (currentPosition > numberOfHearts.Count - 1)
                {
                    currentPosition = 0;
                }

                if (numberOfHearts[currentPosition] == 0)
                {
                    Console.WriteLine($"Place {currentPosition} already had Valentine's day.");
                }
                else
                {
                    numberOfHearts[currentPosition] -= 2;

                    if (numberOfHearts[currentPosition] == 0)
                    {
                        Console.WriteLine($"Place {currentPosition} has Valentine's day.");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {currentPosition}.");

            int counter = numberOfHearts.Count(h => h > 0);

            if (numberOfHearts.Sum() == 0)
            {
                Console.WriteLine("Mission was successful");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {counter} places.");
            }
        }
    }
}
