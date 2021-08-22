using System;

namespace Circle___Perimeter_and_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius: ");
            var r = double.Parse(Console.ReadLine());
            var area = Math.PI * r * r;
            Console.WriteLine(area);
            var per = 2 * r * Math.PI;
            Console.WriteLine(per);
        }
    }
}
