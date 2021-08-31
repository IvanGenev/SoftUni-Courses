using System;
using System.Collections.Generic;
using System.Linq;

namespace TakeSkipRope
{
    class Program
    {
        static void Main()
        {
            // First Version

            string input = Console.ReadLine();

            List<string> text = new();
            List<int> numbers = new();
            List<int> takeList = new();
            List<int> skipList = new();
            string result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    numbers.Add(int.Parse(input[i].ToString()));
                }
                else
                {
                    text.Add(input[i].ToString());
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            int index = 0;
            for (int i = 0; i < takeList.Count; i++)
            {
                int take = takeList[i];
                int skip = skipList[i];

                if (index + take > text.Count)
                {
                    take = text.Count - index;
                }

                for (int j = 0; j < take; j++)
                {
                    result += text[index + j];
                }

                index += take + skip;
            }

            Console.WriteLine(result);


            // Second Version
            //string input = Console.ReadLine();

            //List<int> numbers = input
            //    .Where(x => char.IsDigit(x))
            //    .Select(x => x.ToString())
            //    .Select(int.Parse)
            //    .ToList();

            //List<string> text = input
            //    .ToCharArray()
            //    .Where(x => x < '0' || x > '9')
            //    .Select(x => x.ToString())
            //    .ToList();

            //List<int> takeList = numbers
            //    .Where((x, index) => index % 2 == 0)
            //    .ToList();

            //List<int> skipList = numbers
            //    .Where((x, index) => index % 2 != 0)
            //    .ToList();

            //string result = string.Empty;
            //int index = 0;

            //for (int i = 0; i < takeList.Count; i++)
            //{
            //    List<string> temp = text
            //        .Skip(index)
            //        .Take(takeList[i])
            //        .ToList();

            //    result += string.Concat(temp);
            //    index += takeList[i] + skipList[i];
            //}

            //Console.WriteLine(result);
        }
    }
}
