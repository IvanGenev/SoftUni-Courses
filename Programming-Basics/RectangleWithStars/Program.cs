using System;

namespace RectangleWithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int numRows = n;

            Console.WriteLine(new string('%', n * 2));

            if (n % 2 == 0)
            {
                numRows--;
            }

            for (int i = 0; i < numRows; i++)
            {
                Console.Write("%");
                if (i == numRows / 2)
                {
                    Console.Write(new string(' ', n - 2));
                    Console.Write("**");
                    Console.Write(new string(' ', n - 2));
                }
                else
                {
                    Console.Write(new string(' ', n * 2 - 2));
                }
                Console.Write("%");
                Console.WriteLine();
            }
            Console.WriteLine(new string('%', n * 2));
        }
    }
}
