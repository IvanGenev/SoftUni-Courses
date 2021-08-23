using System;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            int b1 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double area = (b1 + b2) * h / 2.0;

            Console.WriteLine($"{area:f2}");
        }
    }
}
