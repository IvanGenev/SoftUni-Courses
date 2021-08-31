using System;
using System.Text.RegularExpressions;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            // Split(string text) - splits the text by the pattern, Returns string[]

            string text = "1     2 3      4";
            string pattern = @"\s+";
            string[] result = Regex.Split(text, pattern);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
