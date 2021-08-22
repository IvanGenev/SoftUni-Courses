using System;

namespace Trapezoid___Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trapezoid area :");
            Console.Write("enter b1 = ");
            var b1 = double.Parse(Console.ReadLine());
            Console.Write("enter b2 = ");
            var b2 = double.Parse(Console.ReadLine());
            Console.Write("enter h = ");
            var h = double.Parse(Console.ReadLine());
            var area = (b1 + b2) * h / 2;
            Console.WriteLine("The Trapezoid area is " + area);
            
            Console.ReadKey();
        }
    }
}
