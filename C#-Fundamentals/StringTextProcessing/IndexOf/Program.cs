using System;

namespace IndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "The white lazy fox...";

            Console.WriteLine(text.IndexOf("T"));

            Console.WriteLine(text.Substring(0, 6));
        }
    }
}
