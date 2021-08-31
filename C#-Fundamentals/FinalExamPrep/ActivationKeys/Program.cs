using System;
using System.Linq;
using System.Text;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string currentKey = string.Empty;

            string input = Console.ReadLine();

            while (input != "Generate")
            {
                string[] commandArgs = input.Split(">>>");
                string command = commandArgs[0];
                string action = commandArgs[1];

                if (command == "Contains")
                {
                    if (activationKey.Contains(action))
                    {
                        Console.WriteLine($"{activationKey} contains {action}");

                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");

                        input = Console.ReadLine();
                        continue;
                    }
                }
                else if (command == "Flip")
                {
                    int startIndex = int.Parse(commandArgs[2]);
                    int endIndex = int.Parse(commandArgs[3]);
                    int length = endIndex - startIndex;

                    if (action == "Upper")
                    {
                        string newChange = activationKey.Substring(startIndex, length).ToUpper();
                        currentKey = activationKey.Replace(activationKey.Substring(startIndex, length), newChange);

                        Console.WriteLine(currentKey);

                        activationKey = currentKey;

                        input = Console.ReadLine();
                        continue;
                    }
                    else if (action == "Lower")
                    {
                        string newChange = activationKey.Substring(startIndex, length).ToLower();
                        currentKey = activationKey.Replace(activationKey.Substring(startIndex, length), newChange);

                        Console.WriteLine(currentKey);

                        activationKey = currentKey;

                        input = Console.ReadLine();
                        continue;
                    }
                }
                else if (command == "Slice")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);
                    int length = endIndex - startIndex;

                    currentKey = activationKey.Remove(startIndex, length);

                    Console.WriteLine(currentKey);

                    activationKey = currentKey;

                    input = Console.ReadLine();
                    continue;
                }
            }

            Console.WriteLine($"Your activation key is: {currentKey}");
        }
    }
}
