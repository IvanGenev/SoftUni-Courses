using System;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());

            int PeoplePerHour = firstEmployee + secondEmployee + thirdEmployee;

            int timeNeeded = 0;

            while (peopleCount > 0)
            {
                timeNeeded++;

                if (timeNeeded % 4 == 0)
                {
                    continue;
                }
                peopleCount -= PeoplePerHour;
            }
            Console.WriteLine($"Time needed: {timeNeeded}h.");
        }
    }
}
