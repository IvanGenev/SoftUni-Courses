using System;

namespace Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            double numOfCourses = Math.Ceiling(x * 1.0 / (m * w));

            Console.WriteLine(numOfCourses);
        }
    }
}
