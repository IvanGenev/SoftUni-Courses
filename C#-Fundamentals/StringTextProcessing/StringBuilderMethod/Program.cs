using System;
using System.Text;

namespace StringBuilderMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();

            text.Append("some text");
            text.Insert(0, "long");
            text.Replace("some", "all");
        
            Console.WriteLine(text);
            Console.WriteLine(text[0]);
            Console.WriteLine(text.Length);
        }
    }
}
