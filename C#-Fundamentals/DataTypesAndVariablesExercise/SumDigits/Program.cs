using System;
using System.Linq;

namespace SumDigits
{
    class Program
    {
        static void Main()
        {
            int sum = Console.ReadLine()
                .Select(x => int.Parse(x.ToString()))
                .Sum();
            Console.WriteLine(sum);

            //int inputNumber = int.Parse(Console.ReadLine());

            //int sum = 0;

            //while (inputNumber > 0)
            //{
            //    sum += inputNumber % 10;
            //    inputNumber /= 10;
            //}

            //Console.WriteLine(sum);
        }
    }
}
