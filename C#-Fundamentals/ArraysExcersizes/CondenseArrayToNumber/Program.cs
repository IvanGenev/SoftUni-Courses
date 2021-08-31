using System;
using System.Linq;

namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().
                Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();
            var count = input.Length;
            var sum = 0;

            if (count == 1)
            {
                Console.WriteLine(input[0]);
                return;
            }

            while (count > 1)
            {
                for (int i = 0; i < count - 1; i++)
                {
                    input[i] = input[i] + input[i + 1];
                    sum = input[i];
                }

                count--;
            }
            Console.WriteLine(sum);
        }
    }
}
