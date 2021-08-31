using System;
using System.Numerics;

namespace SnowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int highestSnow = 0;
            int highestTime = 0;
            int highestQuality = 0;
            BigInteger highestValue = 0;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (snowballValue > highestValue)
                {
                    highestValue = snowballValue;
                    highestSnow = snowballSnow;
                    highestTime = snowballTime;
                    highestQuality = snowballQuality;
                }

            }
                Console.WriteLine($"{highestSnow} : {highestTime} = {highestValue} ({highestQuality})");
        }
    }
}
