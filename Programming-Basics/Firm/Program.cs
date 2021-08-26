using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            var firmDays = days * 0.90;
            var firmHours = workers * firmDays * 10;

            if (firmHours > hours)
            {
                Console.WriteLine($"Yes!{Math.Floor(firmHours - hours)} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{Math.Floor(hours - firmHours)} hours needed.");
            }
        }
    }
}
