using System;

namespace PrintingArraysForeachStingJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 10, 20, 30, 40, 50 };
            //foreach (var element in arr)
            //{
            //    Console.WriteLine(element);
            //}

            //int[] arr = { 1, 2, 3 };
            //Console.WriteLine(string.Join(", ", arr));

            string[] strings = { "one", "two", "three", "four", "five" };
            Console.WriteLine(string.Join(" - ", strings));
        }
    }
}
