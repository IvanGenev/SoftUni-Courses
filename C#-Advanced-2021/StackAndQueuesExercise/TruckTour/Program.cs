using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int[]> petrolPumps = new Queue<int[]>();

            int numberOfPumps = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPumps; i++)
            {
                int[] currentPump = Console.ReadLine().Split().Select(int.Parse).ToArray();

                petrolPumps.Enqueue(currentPump);
            }

            int index = 0;

            while (true)
            {
                int totalFuel = 0;

                foreach (var item in petrolPumps)
                {
                    int fuelAmount = item[0];
                    int distance = item[1];

                    totalFuel += fuelAmount - distance;

                    if (totalFuel < 0)
                    {
                        petrolPumps.Enqueue(petrolPumps.Dequeue());
                        index++;
                        break;
                    }
                }

                if (totalFuel >= 0)
                {
                    break;
                }
            }

            Console.WriteLine(index);
        }
    }
}
