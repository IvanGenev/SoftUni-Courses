using System;

namespace EqualSumsEvenOddPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());

            //for (int i = num1; i <= num2; i++)
            //{
            //    string currentNum = i.ToString();
            //    int oddSum = 0;
            //    int evenSum = 0;

            //    for (int j = 0; j < currentNum.Length; j++)
            //    {
            //        int currentDigit = int.Parse(currentNum[j].ToString());
            //        if (j % 2 == 0)
            //        {
            //            evenSum += currentDigit;
            //        }
            //        else
            //        {
            //            oddSum += currentDigit;
            //        }
            //    }
            //    if (oddSum == evenSum)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                int currentNum = i;
                int evenSum = 0;
                int oddSum = 0;
                int count = 0;

                while (currentNum != 0)
                {
                    int digit = currentNum % 10;
                    if (count % 2 == 0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }
                    currentNum = currentNum / 10;
                    count++;
                }
                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
