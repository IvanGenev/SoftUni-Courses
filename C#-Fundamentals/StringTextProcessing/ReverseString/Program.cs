using System;
using System.Text;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder reversed = new StringBuilder();

            while (input != "end")
            {
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversed.Append(input[i]);
                }

                Console.WriteLine($"{input} = {reversed}");

                reversed.Clear();

                input = Console.ReadLine();
            }
        }
    }
}
