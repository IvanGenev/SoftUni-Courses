using System;

namespace EvenNumbers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            while (number != 0)
            {
                if (number % 2 == 0)
                {

                    Console.WriteLine("The number is: " + Math.Abs(number));
                }
                else
                {
                    Console.WriteLine("Please write an even number.");

                }

                number = int.Parse(Console.ReadLine());
            }

            //for (int i = 1; i <= input.Length; i++)
            //{

            //    if (number % 2 == 0)
            //    {

            //        Console.WriteLine("The number is: " + Math.Abs(number));
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please write an even number.");

            //    }

            //}
        }
    }
}
