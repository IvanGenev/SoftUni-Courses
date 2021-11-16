using System;
using System.Collections.Generic;
using System.Linq;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            var vowels = new Queue<char>(Console.ReadLine().Split(' ').Select(char.Parse));
            var consonants = new Stack<char>(Console.ReadLine().Split(' ').Select(char.Parse));

            int wordsCount = 0;

            List<char> pear = new List<char> { 'p', 'e', 'a', 'r' };
            List<char> flour = new List<char> { 'f', 'l', 'o', 'u', 'r' };
            List<char> pork = new List<char> { 'p', 'o', 'r', 'k' };
            List<char> olive = new List<char> { 'o', 'l', 'i', 'v', 'e' };

            List<char> pearLetters = new List<char>();
            List<char> flourLetters = new List<char>();
            List<char> porkLetters = new List<char>();
            List<char> oliveLetters = new List<char>();

            List<string> wordsFound = new List<string>();

            while (consonants.Count > 0)
            {
                var currentVowel = vowels.Peek();
                var currentConsonant = consonants.Peek();

                if (pear.Contains(currentVowel))
                {
                    if (!pearLetters.Contains(currentVowel))
                    {
                        pearLetters.Add(currentVowel);
                    }
                }
                if (pear.Contains(currentConsonant))
                {
                    if (!pearLetters.Contains(currentConsonant))
                    {
                        pearLetters.Add(currentConsonant);
                    }
                }

                if (flour.Contains(currentVowel))
                {
                    if (!flourLetters.Contains(currentVowel))
                    {
                        flourLetters.Add(currentVowel);
                    }
                }
                if (flour.Contains(currentConsonant))
                {
                    if (!flourLetters.Contains(currentConsonant))
                    {
                        flourLetters.Add(currentConsonant);
                    }
                }

                if (pork.Contains(currentVowel))
                {
                    if (!porkLetters.Contains(currentVowel))
                    {
                        porkLetters.Add(currentVowel);
                    }
                }
                if (pork.Contains(currentConsonant))
                {
                    if (!porkLetters.Contains(currentConsonant))
                    {
                        porkLetters.Add(currentConsonant);
                    }
                }

                if (olive.Contains(currentVowel))
                {
                    if (!oliveLetters.Contains(currentVowel))
                    {
                        oliveLetters.Add(currentVowel);
                    }
                }
                if (olive.Contains(currentConsonant))
                {
                    if (!oliveLetters.Contains(currentConsonant))
                    {
                        oliveLetters.Add(currentConsonant);
                    }
                }

                vowels.Dequeue();
                vowels.Enqueue(currentVowel);
                consonants.Pop();
            }

            if (pear.Count == pearLetters.Count)
            {
                wordsCount++;
                wordsFound.Add("pear");
            }
            if (flour.Count == flourLetters.Count)
            {
                wordsCount++;
                wordsFound.Add("flour");
            }
            if (pork.Count == porkLetters.Count)
            {
                wordsCount++;
                wordsFound.Add("pork");
            }
            if (olive.Count == oliveLetters.Count)
            {
                wordsCount++;
                wordsFound.Add("olive");
            }

            Console.WriteLine($"Words found: {wordsCount}");

            foreach (var item in wordsFound)
            {
                Console.WriteLine(item);
            }
        }
    }
}
