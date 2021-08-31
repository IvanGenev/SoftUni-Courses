using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> inputUsers = new Dictionary<string, string>();

            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputNumber; i++)
            {
                string[] input = Console.ReadLine().Split();

                string command = input[0];
                string userName = input[1];
                string licensePlate = string.Empty;

                if (input.Length == 3)
                {
                    licensePlate = input[2];
                }

                if (command == "register")
                {
                    if (!inputUsers.ContainsKey(userName))
                    {
                        inputUsers.Add(userName, licensePlate);
                        Console.WriteLine($"{userName} registered {licensePlate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    }
                }
                else if (command == "unregister")
                {
                    if (!inputUsers.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{userName} unregistered successfully");
                        inputUsers.Remove(userName);
                    }
                }
            }

            foreach (var user in inputUsers)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
