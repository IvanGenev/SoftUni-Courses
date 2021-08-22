using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double volumeCM = length * width * hight;
            double volumeDM = volumeCM / 1000;
            double percent = percentage / 100;

            double total = volumeDM - (volumeDM * percent);

            Console.WriteLine(total);
        }
    }
}
