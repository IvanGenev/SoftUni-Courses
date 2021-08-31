using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string first = "Strasse";
            //string second = "Straße";
            //Console.WriteLine(first == second);
            //Console.WriteLine(first.CompareTo(second));

            //string name = "Ivan is";
            //string age = " 36 years old";
            //Console.WriteLine(string.Concat(name, age));

            string quote = "The main intent of the \" Intro C#\"" + " book is to introduce the C# programming to newbies.";
            string keyword = "C#";
            int index = quote.IndexOf(keyword);

            while (index != -1)
            {
                Console.WriteLine("{0} found at index: {1}", keyword, index);
                index = quote.IndexOf(keyword, index + keyword.Length);
            }
        }
    }
}
