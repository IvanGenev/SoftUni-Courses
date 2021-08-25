using System;

namespace BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int finishNum = int.Parse(Console.ReadLine());

            int s1 = 0;
            int s2 = 0;
            int s3 = 0;
            int s4 = 0;
            int f1 = 0;
            int f2 = 0;
            int f3 = 0;
            int f4 = 0;

            s4 = startNum % 10;
            f4 = finishNum % 10;
            startNum /= 10;
            finishNum /= 10;
            s3 = startNum % 10;
            f3 = finishNum % 10;
            startNum /= 10;
            finishNum /= 10;
            s2 = startNum % 10;
            f2 = finishNum % 10;
            startNum /= 10;
            finishNum /= 10;
            s1 = startNum % 10;
            f1 = finishNum % 10;
            startNum /= 10;
            finishNum /= 10;

            for (int i = s1; i <= f1; i++)
            {
                for (int j = s2; j <= f2; j++)
                {
                    for (int k = s3; k <= f3; k++)
                    {
                        for (int l = s4; l <= f4; l++)
                        {
                            if (i % 2 !=0 && j % 2 != 0 && k % 2 != 0 && l % 2 !=0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
