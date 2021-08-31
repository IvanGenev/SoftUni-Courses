using System;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArgs = command.Split(' ',
                    StringSplitOptions.RemoveEmptyEntries);

                string action = commandArgs[0];

                if (action == "exchange")
                {
                    int index = int.Parse(commandArgs[1]);

                    if (index >= numbers.Length || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        command = Console.ReadLine();
                        continue;
                    }

                    Exchange(numbers, index);

                }
                else if (action == "max")
                {
                    string evenOddCommand = commandArgs[1];
                    int evenOddNumber = GetEvenOddNumber(evenOddCommand);
                    int maxIndex = GetMax(numbers, evenOddNumber);
                    PrintMaxMinNumber(maxIndex);
                }
                else if (action == "min")
                {
                    string evenOddCommand = commandArgs[1];
                    int evenOddNumber = GetEvenOddNumber(evenOddCommand);
                    int minIndex = GetMin(numbers, evenOddNumber);
                    PrintMaxMinNumber(minIndex);
                }
                else if (action == "first")
                {
                    int count = int.Parse(commandArgs[1]);
                    int evenOddNumber = GetEvenOddNumber(commandArgs[2]);

                    if (count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        command = Console.ReadLine();
                        continue;
                    }

                    int[] firstNumbers = GetFirstNumbers(numbers, evenOddNumber, count);
                    PrintArray(firstNumbers);
                }
                else if (action == "last")
                {
                    int count = int.Parse(commandArgs[1]);
                    int evenOddNumber = GetEvenOddNumber(commandArgs[2]);

                    if (count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        command = Console.ReadLine();
                        continue;
                    }

                    int[] lastNumbers = GetLastNumbers(numbers, evenOddNumber, count);
                    PrintArray(lastNumbers);
                }

                command = Console.ReadLine();
            }

            PrintArray(numbers);
        }

        static int[] GetLastNumbers(int[] numbers, int evenOddNumber, int count)
        {
            int arrayLength = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (arrayLength == count)
                {
                    break;
                }

                if (numbers[i] % 2 == evenOddNumber)
                {
                    arrayLength++;
                }
            }

            int[] lastNumbers = new int[arrayLength];
            int counter = arrayLength - 1;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (arrayLength == 0)
                {
                    break;
                }

                if (numbers[i] % 2 == evenOddNumber)
                {
                    lastNumbers[counter--] = numbers[i];
                    arrayLength--;
                }
            }

            return lastNumbers;
        }

        static void PrintArray(int[] firstNumbers)
        {
            if (firstNumbers.Length == 0)
            {
                Console.WriteLine("[]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", firstNumbers)}]");
            }
        }

        static int[] GetFirstNumbers(int[] numbers, int evenOddNumber, int count)
        {
            int arrayLength = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (arrayLength == count)
                {
                    break;
                }

                if (numbers[i] % 2 == evenOddNumber)
                {
                    arrayLength++;
                }
            }

            int[] firstNumbers = new int[arrayLength];
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (arrayLength == 0)
                {
                    break;
                }

                if (numbers[i] % 2 == evenOddNumber)
                {
                    firstNumbers[counter++] = numbers[i];
                    arrayLength--;
                }
            }

            return firstNumbers;
        }

        static void PrintMaxMinNumber(int maxIndex)
        {
            if (maxIndex == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxIndex);
            }
        }

        static int GetMin(int[] numbers, int evenOddNumber)
        {
            int minIndex = -1;
            int minValue = int.MaxValue;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] < minValue && numbers[i] % 2 == evenOddNumber)
                {
                    minValue = numbers[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        static int GetMax(int[] numbers, int oddEven)
        {
            int maxIndex = -1;
            int maxValue = int.MinValue;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] > maxValue && numbers[i] % 2 == oddEven)
                {
                    maxValue = numbers[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        static void Exchange(int[] numbers, int index)
        {
            int[] leftArray = new int[index + 1];
            int[] rightArray = new int[numbers.Length - index - 1];

            for (int i = 0; i < leftArray.Length; i++)
            {
                leftArray[i] = numbers[i];
            }

            int counter = 0;

            for (int i = index + 1; i < numbers.Length; i++)
            {
                rightArray[counter++] = numbers[i];
            }

            for (int i = 0; i < rightArray.Length; i++)
            {
                numbers[i] = rightArray[i];
            }

            counter = 0;

            for (int i = numbers.Length - index - 1; i < numbers.Length; i++)
            {
                numbers[i] = leftArray[counter++];
            }
        }

        static int GetEvenOddNumber(string evenOddCommand)
        {
            if (evenOddCommand == "even")
            {
                return 0;
            }

            return 1;
        }
    }
}
