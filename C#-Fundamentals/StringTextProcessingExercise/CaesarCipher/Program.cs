using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string cipher = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                letter += (char)3;
                cipher += letter;
            }

            Console.WriteLine(cipher);
        }
    }
}
