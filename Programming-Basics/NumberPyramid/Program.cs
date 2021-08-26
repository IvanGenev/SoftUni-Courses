using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());

            //int current = 1;
            //bool isBigger = false;

            //for (int rows = 1; rows <= n; rows++)
            //{
            //    for (int cols = 1; cols <= rows; cols++)
            //    {
            //        if (current > n)
            //        {
            //            isBigger = true;
            //            break;
            //        }
            //        Console.Write(current + " ");
            //        current++;
            //    }
            //    if (isBigger)
            //    {
            //        break;
            //    }
            //    Console.WriteLine();
            //}

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i < end; i++)
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
