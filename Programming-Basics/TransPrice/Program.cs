using System;

namespace TransPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string dayNight = Console.ReadLine();
            double transCost = 0;
            double taxiRate = 0;

            if (dayNight == "day")
            {
                taxiRate = 0.79;
            }
            else
            {
                taxiRate = 0.90;
            }
            if (distance < 20)
            {
                transCost = distance * taxiRate + 0.70;
            }
            else if (distance < 100)
            {
                transCost = distance * 0.09;
            }
            else
            {
                transCost = distance * 0.06;
            }

            Console.WriteLine(transCost);
        }
    }
}
