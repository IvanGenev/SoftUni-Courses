using System;
using System.Collections.Generic;

namespace StackUtilityMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int count = stack.Count; // Show the count of elements
            bool exists = stack.Contains(2); // Check whether contain
            int[] array = stack.ToArray(); // Retains the order of elements
            stack.Clear(); // Remove all elements
            stack.TrimExcess(); // Resize the internal array
        }
    }
}
