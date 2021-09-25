using System;
using System.Collections.Generic;

namespace QueueUtilityMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            int count = queue.Count; // shows the count of elements in the queue
            bool exists = queue.Contains(2); // shows wether it contains 2
            int[] array = queue.ToArray(); // returns an array with the same order of elements
            queue.Clear(); // removes all elements
            queue.TrimExcess(); // removes excess empty entries
        }
    }
}
