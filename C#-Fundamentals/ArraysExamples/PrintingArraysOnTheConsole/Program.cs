using System;

namespace PrintingArraysOnTheConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "one", "two", "three", "four", "five" };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
            }
        }
    }
}
