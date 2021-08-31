using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 1; num <= n; num++)
            {
                int sumOfDigits = 0;
                int digits = num;

                while (digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                }

                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    Console.WriteLine("{0} -> True", num);
                }
                else
                {
                    Console.WriteLine("{0} -> False", num);

                }
            }
        }
    }
}
