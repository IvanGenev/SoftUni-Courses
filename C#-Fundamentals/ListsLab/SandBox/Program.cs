using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;

namespace SandBox
{

    public class Example
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());
                numbers[i] = newNumber;
                Console.WriteLine(string.Join(" ", numbers.Reverse()));
            }
        }
    }
}
