using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dailyGoal = 10000;
            int stepsCounter = 0;
            string input = Console.ReadLine();

            while (input != "Going home")
            {
                int steps = int.Parse(input);
                stepsCounter += steps;
                if (stepsCounter >= dailyGoal)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsCounter - dailyGoal} steps over the goal!");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "Going home")
            {
                int stepsToHome = int.Parse(Console.ReadLine());
                stepsCounter += stepsToHome;

                if (stepsCounter < dailyGoal)
                {
                    Console.WriteLine($"{dailyGoal - stepsCounter} more steps to reach goal.");
                }
                else
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{stepsCounter - dailyGoal} steps over the goal!");
                }
            }
        }
    }
}
