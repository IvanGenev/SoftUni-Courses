using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            //string word = Console.ReadLine();
            //string text = Console.ReadLine();

            //int indexOfWord = text.IndexOf(word);

            //while (indexOfWord >= 0)
            //{
            //    text = text.Remove(indexOfWord, word.Length);
            //    indexOfWord = text.IndexOf(word);
            //}

            //Console.WriteLine(text);

            string key = Console.ReadLine();
            string text = Console.ReadLine();

            int index = text.IndexOf(key);

            while (index != -1)
            {
                text = text.Remove(index, key.Length);
                index = text.IndexOf(key);
            }

            Console.WriteLine(text);
        }
    }
}
