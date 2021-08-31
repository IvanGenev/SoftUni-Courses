using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int sum = Sum(a, b);
            int subtract = Subtract(sum, c);

            Console.WriteLine(subtract);
        }

        private static int Subtract(int sum, int c)
        {
            int result = sum - c;

            return result;
        }

        static int Sum(int a, int b)
        {
            int result = a + b;
            
            return result;
        }
    }
}
