using System;

namespace Radians_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad = double.Parse(Console.ReadLine());
            double deg = (180.0 / Math.PI) * rad;
            Console.WriteLine(Math.Round(deg));
        }
    }
}
