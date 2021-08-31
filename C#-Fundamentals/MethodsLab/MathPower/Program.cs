using System;

namespace MathPower
{
    class Program
    {
        static double MathPower(double number, int power)
        {
            double result = 0d;

            //for (int i = 0; i < power; i++)
            //    result *= number;

            // OR

            result = Math.Pow(number, power);

            return result;
        }

        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(MathPower(number, power));
        }
    }
}
