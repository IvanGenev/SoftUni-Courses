using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());

            long[][] trianglePascal = new long[height][];

            for (int i = 0; i < height; i++)
            {
                long[] row = new long[i + 1];
                row[0] = 1;
                row[i] = 1;

                for (int j = 1; j < i; j++)
                {
                    row[j] = trianglePascal[i - 1][j] + trianglePascal[i - 1][j - 1];
                }

                trianglePascal[i] = row;
            }

            for (int i = 0; i < height; i++)
            {
                Console.WriteLine(string.Join(' ', trianglePascal[i]));
            }
        }
    }
}
