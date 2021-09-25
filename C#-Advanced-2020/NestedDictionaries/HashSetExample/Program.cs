using System;
using System.Collections.Generic;

namespace HashSetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("Ivan");
            set.Add("Valentina");

            Console.WriteLine(string.Join(", ", set));
        }
    }
}
