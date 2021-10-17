using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(inputNumber))
                {
                    numbers.Add(inputNumber, 0);
                }

                numbers[inputNumber]++;
            }

            // Finding the even Key:

            // First way:
            // int number = numbers.Where(x => x.Value % 2 == 0).FirstOrDefault().Key;
            //Console.WriteLine(number);

            // Second way:
            //int number = numbers.FirstOrDefault(x => x.Value % 2 == 0).Key;
            //Console.WriteLine(number);

            // Third way:
            foreach (var (key, value) in numbers)
            {
                if (value % 2 == 0)
                {
                    Console.WriteLine(key);
                    break;
                }
            }
        }
    }
}
