using System;
using System.Collections.Generic;
using System.Linq;

namespace SandBoxMethodsLab
{
    class Program
    {
        static void Main()
        {
            string dataType = Console.ReadLine();

            switch (dataType)
            {
                case "int":
                    int firstInt = int.Parse(Console.ReadLine());
                    int secondInt = int.Parse(Console.ReadLine());
                    int resultInt = GetMax(firstInt, secondInt);
                    Console.WriteLine(resultInt);
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    char resultChar = GetMax(firstChar, secondChar);
                    Console.WriteLine(resultChar);
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    string resultString = GetMax(firstString, secondString);
                    Console.WriteLine(resultString);
                    break;
            }
        }

        static int GetMax(int first, int second) => Math.Max(first, second);
        static char GetMax(char first, char second) => (char)Math.Max(first, second);
        static string GetMax(string first, string second)
        {
            int comparision = first.CompareTo(second);
            if (comparision >= 0)
                return first;
            else
                return second;
        }
    }
}
