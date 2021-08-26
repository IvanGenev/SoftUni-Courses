using System;
using System.Threading;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int days = 0; days < 28; days++)
            //{
            //    Console.WriteLine($"Date: {days:d2}.02.2021");

            //    for (int hour = 0; hour < 24; hour++)
            //    {
            //        for (int min = 0; min < 60; min++)
            //        {
            //            for (int sec = 0; sec < 60; sec++)
            //            {
            //                Console.WriteLine($"Time: {hour:d2}:{min:d2}:{sec:d2}");
            //                Thread.Sleep(1000);
            //            }
            //        }
            //    }
            //}

            for (int h = 0; h < 24; h++)
            {
                for (int m = 0; m < 60; m++)
                {
                    Console.WriteLine($"{h}:{m}");
                }
            }
        }
    }
}
