using System;
using System.IO;
using System.Linq;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // A way to read the whole text and put it into one string:
            //string allText = File.ReadAllText("text.txt");

            string[] lines = File.ReadAllLines("text.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                int lettersCount = lines[i]
                    .Count(symbol => char.IsLetter(symbol));
                int punctuationCount = lines[i]
                    .Count(symbol => char.IsPunctuation(symbol));

                File.AppendAllText("output.txt", $"Line {i + 1}: {lines[i]} ({lettersCount})({punctuationCount}){Environment.NewLine}");
            }
        }
    }
}
