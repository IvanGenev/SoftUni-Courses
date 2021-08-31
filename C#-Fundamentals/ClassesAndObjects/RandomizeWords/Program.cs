using System;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Random random = new Random();
            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {
                int pos2 = random.Next(words.Length);
                string current = words[pos1];
                words[pos1] = words[pos2];
                words[pos2] = current;
            }

            Console.WriteLine(string.Join("\n", words));
        }
    }
}
