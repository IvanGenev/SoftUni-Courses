using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesQty = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());

            int clothesSum = 0;
            int countOfRacks = 1;
            int lastAdded = 0;

            Stack<int> clothesBox = new Stack<int>(clothesQty);

            while (clothesBox.Count > 0)
            {
                if (clothesSum < rackCapacity)
                {
                    lastAdded = clothesBox.Pop();
                    clothesSum += lastAdded;
                }
                if (clothesSum > rackCapacity)
                {
                    clothesBox.Push(lastAdded);
                    countOfRacks++;
                    clothesSum = 0;
                }
                else if (clothesSum == rackCapacity)
                {
                    countOfRacks++;
                    clothesSum = 0;
                }
            }

            Console.WriteLine(countOfRacks);
        }
    }
}
