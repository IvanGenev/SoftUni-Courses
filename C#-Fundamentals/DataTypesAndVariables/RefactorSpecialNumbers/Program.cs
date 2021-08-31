using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isSpecialNum = false;
            for (int num = 1; num <= n; num++)
            {
                int sumOfDigits = 0;
                int curentNum = num;
                while (num > 0)
                {
                    sumOfDigits += num % 10;
                    num = num / 10;
                }
                isSpecialNum = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine("{0} -> {1}", curentNum, isSpecialNum);
                num = curentNum;
            }

        }
    }
}
