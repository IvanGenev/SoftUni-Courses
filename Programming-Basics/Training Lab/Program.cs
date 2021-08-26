using System;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine()) * 100;
            double width = double.Parse(Console.ReadLine()) * 100;

            double columns = Math.Truncate((width - 100) / 70);
            double rows = Math.Truncate(length / 120);
            double seats = columns * rows - 3;

            Console.WriteLine(seats);
        }
    }
}
