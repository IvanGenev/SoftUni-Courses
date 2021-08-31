using System;
using System.Linq;

namespace PrintNumberInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the array (n Lines of integers)
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());
                arr[i] = newNumber;
            }
            Console.WriteLine(string.Join(" ", arr.Reverse()));

            //// Print the elements form the last to the first
            //for (int i = n - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();
        }
    }
}
