using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQty = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(orders);

            Console.WriteLine(queue.Max());

            int sumOrders = 0;

            while (queue.Count > 0)
            {
                int firstCustomer = queue.Peek();
                sumOrders += firstCustomer;

                if (sumOrders <= foodQty)
                {
                    queue.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(' ', queue)}");
                    return;
                }
            }

            Console.WriteLine("Orders complete");
        }
    }
}
