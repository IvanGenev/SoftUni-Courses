using System;

namespace Training_Lab_2nd_version
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine()) * 100;
            var width = double.Parse(Console.ReadLine()) * 100;

            int columns = ((int)width - 100) / 70;
            int rows = (int)length / 120;
            int seats = rows * columns - 3;

            Console.WriteLine(seats);
        }
    }
}
