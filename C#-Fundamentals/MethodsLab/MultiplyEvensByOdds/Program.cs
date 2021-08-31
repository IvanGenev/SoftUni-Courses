using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static int GetSumOfOddDigits(int number)
        {
            int sumOfOdds = 0;

            while (number > 0)
            {
                int nextNum = number % 10;

                if (nextNum % 2 != 0)
                    sumOfOdds += nextNum;
                
                number /= 10;
            }

            return sumOfOdds;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sumOfEvens = 0;

            while (number > 0)
            {
                int nextNum = number % 10;

                if (nextNum % 2 == 0)
                    sumOfEvens += nextNum;
                
                number /= 10;
            }

            return sumOfEvens;
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            int MultipleOfEvenAndOdds = GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);

            return MultipleOfEvenAndOdds;
        }

        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int MultipleOfEvensAndOdds = GetMultipleOfEvenAndOdds(number);

            Console.WriteLine(MultipleOfEvensAndOdds);
        }
    }
}
