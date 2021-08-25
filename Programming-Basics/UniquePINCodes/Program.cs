using System;

namespace UniquePINCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFirst = int.Parse(Console.ReadLine());
            int numSecond = int.Parse(Console.ReadLine());
            int numThird = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numFirst; i++)
            {
                for (int j = 1; j <= numSecond; j++)
                {
                    for (int k = 1; k <= numThird; k++)
                    {
                        if (i % 2 == 0 && (j == 2 || j == 3 || j == 5 || j == 7) && k % 2 == 0)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
    }
}
