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

            Queue<int> queueOfOrders = new Queue<int>();

            foreach (var order in orders)
            {
                queueOfOrders.Enqueue(order);
            }

            int maxOrder = int.MinValue;

            while (queueOfOrders.Count > 0 && foodQty > 0)
            {
                int currentOrder = queueOfOrders.Peek();

                if (currentOrder > maxOrder)
                {
                    maxOrder = currentOrder;
                }

                if (foodQty - currentOrder < 0)
                {
                    break;
                }

                queueOfOrders.Dequeue();
                foodQty -= currentOrder;
            }

            Console.WriteLine(maxOrder);

            if (queueOfOrders.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queueOfOrders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
