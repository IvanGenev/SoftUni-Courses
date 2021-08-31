using System;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.";
            string[] words = text.Split(new string[] { " ", ", ", "." }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
