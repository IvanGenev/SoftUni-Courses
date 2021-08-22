using System;

namespace Celsius___Farenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Celsius - ");
            var Celsius = double.Parse(Console.ReadLine());
            var Fahrenheit = (Celsius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit - " + Fahrenheit);
        }
    }
}
