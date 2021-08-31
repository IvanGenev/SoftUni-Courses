using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            // StringBuilder methods

            // Append(..) - add text or a string representation of an object to the end of a string

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello, Ivan");

            // Lenght - holds the length of the string in the buffer

            Console.WriteLine(sb.Length);

            // Clear() - removes all characters

            // [int index] - return char on current index

            Console.WriteLine(sb[7]);

            // Insert(int index, string str) - inserts a strng at the specified character position

            sb.Insert(11, "GOGO");
            Console.WriteLine(sb);

            // Replace(string old, string new) - replaces all occurences of a specified string with another specified string

            sb.Replace("GOGO", "Start");
            Console.WriteLine(sb);
        }
    }
}
