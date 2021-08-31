using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                sum += symbol;

                //string inputChar = Console.ReadLine();
                //sum += inputChar[0];
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
