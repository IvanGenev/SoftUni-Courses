using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            List<int> totalRaceTime = new List<int>(input);

            List<int> leftCarTime = new();
            List<int> rightCarTime = new();

            double leftTime = 0;
            double rightTime = 0;

            for (int i = 0; i < (totalRaceTime.Count - 1) / 2; i++)
            {
                leftCarTime.Add(totalRaceTime[i]);

                rightCarTime.Add(totalRaceTime[totalRaceTime.Count - 1 - i]);
            }

            foreach (double time in leftCarTime)
            {
                if (time == 0)
                {
                    leftTime *= 0.8;
                }
                leftTime += time;
            }

            foreach (double time in rightCarTime)
            {
                if (time == 0)
                {
                    rightTime *= 0.8;
                }
                rightTime += time;
            }

            if (leftTime > rightTime)
            {
                Console.WriteLine("The winner is left with total time: {0:f1}", leftTime);
            }
            else
            {
                Console.WriteLine("The winner is right with total time: {0:f1}", rightTime);
            }
        }
    }
}
