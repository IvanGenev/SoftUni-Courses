using System;
using System.Linq;

namespace CountUppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(
                new char[] { ' ', '.', '!', '?', ',', ':', ':' }, StringSplitOptions.RemoveEmptyEntries);

            Func<string, bool> upperCaseFirstLetter = word => char.IsUpper(word[0]);

            var upperLetterWords = words.Where(upperCaseFirstLetter);

            foreach (var word in upperLetterWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
