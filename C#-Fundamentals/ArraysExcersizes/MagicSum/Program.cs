using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int givenNumber = int.Parse(Console.ReadLine());

            int firstCouple = 0;
            int secondCouple = 0;

            for (int iFirst = 0; iFirst < input.Length; iFirst++)
            {
                firstCouple = input[iFirst];

                for (int iSecond = iFirst + 1; iSecond < input.Length; iSecond++)
                {
                    secondCouple = input[iSecond];

                    if (givenNumber == (firstCouple + secondCouple))
                    {
                        Console.Write(firstCouple + " ");

                        Console.WriteLine(secondCouple + " ");
                    }
                }
            }
        }
    }
}
