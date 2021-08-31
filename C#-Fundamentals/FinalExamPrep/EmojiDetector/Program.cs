using System;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string emojiPattern = @"([:*])\1([A-Z][a-z]{2,})\1{2}";
            string coolThresholdPattern = @"[0-9]";
            long coolThreshold = 1;

            var threshold = Regex.Matches(input, coolThresholdPattern);

            foreach (Match digit in threshold)
            {
                coolThreshold *= int.Parse(digit.Value);
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");

            var emoji = Regex.Matches(input, emojiPattern);

            Console.WriteLine($"{emoji.Count} emojis found in the text. The cool ones are:");

            foreach (Match match in emoji)
            {
                long coolness = 0;

                string emojiGroup = match.Groups[2].Value;

                for (int i = 0; i < emojiGroup.Length; i++)
                {
                    coolness += emojiGroup[i];
                }

                if (coolness >= coolThreshold)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }
    }
}
