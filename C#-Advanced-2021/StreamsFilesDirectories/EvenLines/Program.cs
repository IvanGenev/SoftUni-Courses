using System;
using System.IO;
using System.Linq;

namespace EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("text.txt");

            string result = sr.ReadToEnd();

            string[] specialSymbols = new[] { "-", ",", ".", "!", "?" };

            foreach (var symbol in specialSymbols)
            {
                result = result.Replace(symbol, "@");
            }

            Console.WriteLine(string.Join(" ", result.Split().Reverse()));
        }
    }
}
