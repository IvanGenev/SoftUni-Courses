using System;

namespace SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeDays = int.Parse(Console.ReadLine());

            int workDays = 365 - freeDays;
            int playTime = workDays * 63 + freeDays * 127;
            var difference = Math.Abs(playTime - 30000);
            var hours = difference / 60;
            var minutes = difference % 60;

            if (playTime > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }
        }
    }
}
