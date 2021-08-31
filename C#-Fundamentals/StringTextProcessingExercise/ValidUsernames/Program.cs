using System;
using System.Linq;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var currentUsername in input)
            {
                if (currentUsername.Length < 3 || currentUsername.Length > 16)
                {
                    continue;
                }

                bool isValid = false;

                foreach (var symbol in currentUsername)
                {
                    if (!(char.IsDigit(symbol) ||
                        char.IsLetter(symbol) ||
                        symbol == '-' ||
                        symbol == '_'))
                    {
                        isValid = false;
                        break;
                    }

                    isValid = true;
                }

                if (isValid)
                {
                    Console.WriteLine(currentUsername);
                }
            }
        }
    }
}
