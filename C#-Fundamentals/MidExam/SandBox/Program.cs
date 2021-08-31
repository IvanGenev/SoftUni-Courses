using System;
using System.Collections.Generic;
using System.Linq;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            double food = double.Parse(Console.ReadLine()) * 1000;
            double hay = double.Parse(Console.ReadLine()) * 1000;
            double cover = double.Parse(Console.ReadLine()) * 1000;
            double weightPuppy = double.Parse(Console.ReadLine()) * 1000;

            int days = 30;

            bool notEnough = false;

            for (int i = 0; i < days; i++)
            {
                food -= 300;


                if (i % 2 == 0)
                {
                    hay -= (food - 300) * 0.05;
                }
                if (i % 3 == 0)
                {
                    cover -= weightPuppy / 3;
                }

                if (food <= 0 || hay <= 0 || cover <= 0)
                {
                    notEnough = true;
                    break;
                }
                
            }

            if (notEnough)
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
            else
            {
                Console.WriteLine("Everything is fine! Puppy is happy! Food: {0:f2}, Hay: {1:f2}, Cover: {2:f2}."
                    , (food / 1000), (hay / 1000), (cover / 1000));
            }
        }
    }
}
