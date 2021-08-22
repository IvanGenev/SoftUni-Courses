using System;

namespace Triangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            var h = double.Parse(Console.ReadLine());
            var area = (a * h / 2);
            Console.WriteLine("Triangle area = " + Math.Round(area, 2));
        }
    }
}
