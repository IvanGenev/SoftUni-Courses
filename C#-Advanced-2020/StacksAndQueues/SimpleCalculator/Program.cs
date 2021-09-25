using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var values = input.Split(' ');
            var stack = new Stack<string>(values.Reverse());

            while (stack.Count > 1)
            {
                int first = int.Parse(stack.Pop());
                string operators = stack.Pop();
                int second = int.Parse(stack.Pop());

                if (operators == "+")
                {
                    stack.Push((first + second).ToString());
                }
                else if (operators == "-")
                {
                    stack.Push((first - second).ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
