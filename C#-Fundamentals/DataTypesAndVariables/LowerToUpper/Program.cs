using System;

namespace LowerToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char newChar = char.Parse(Console.ReadLine());

            if (Char.IsUpper(newChar))
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
