using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //var number = int.Parse(Console.ReadLine());
            //var times = int.Parse(Console.ReadLine());

            //if (times > 10)
            //{
            //    Console.WriteLine($"{number} X {times} = {number * times}");
            //}

            //while (times <= 10)
            //{
            //    Console.WriteLine($"{number} X {times} = {number * times}");
            //    times++;
            //}

            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);
        }
    }
}
