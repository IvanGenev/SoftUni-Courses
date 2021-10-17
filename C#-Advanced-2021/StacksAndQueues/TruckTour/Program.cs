using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int[]> truckRoad = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                truckRoad.Enqueue(input);
            }

            int startPoint = 0;

            while (true)
            {
                int currentPetrol = 0;

                foreach (var fuelKm in truckRoad)
                {
                    int truckPetrol = fuelKm[0];
                    int truckDistance = fuelKm[1];

                    currentPetrol += truckPetrol;
                    currentPetrol -= truckDistance;

                    if (currentPetrol < 0)
                    {
                        int[] petrolStation = truckRoad.Dequeue();
                        truckRoad.Enqueue(petrolStation);
                        startPoint++;
                        break;
                    }
                }

                if (currentPetrol >= 0)
                {
                    Console.WriteLine(startPoint);
                    break;
                }
            }
        }
    }
}
