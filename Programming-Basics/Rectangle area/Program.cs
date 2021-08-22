using System;

namespace Rectangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1 = ");
            var x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            var y1 = double.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            var x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            var y2 = double.Parse(Console.ReadLine());
            var width = Math.Max(x1, x2) - Math.Min(x1, x2);
            var height = Math.Max(y1, y2) - Math.Min(y1, y2);
            Console.WriteLine("Area = " + width * height);
            Console.WriteLine("Perimeter = " + 2 * (width + height));
        }
    }
}
