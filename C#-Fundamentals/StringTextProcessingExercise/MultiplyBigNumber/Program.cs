using System;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int digit = int.Parse(Console.ReadLine());

            int remainder = 0;

            StringBuilder stringBuilder = new StringBuilder();

            if (input == "0" || digit == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = input.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(input[i].ToString());

                int product = currentDigit * digit + remainder;

                int result = product % 10;

                remainder = product / 10;

                stringBuilder.Insert(0, result);
            }

            if (remainder > 0)
            {
                stringBuilder.Insert(0, remainder);
            }

            Console.WriteLine(stringBuilder);
        }
    }
}
