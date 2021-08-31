using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            GetMiddleChar(inputText);
        }

        static void GetMiddleChar(string inputText)
        {
            string result = string.Empty;

            if (inputText.Length % 2 == 1)
            {
                result = inputText[inputText.Length / 2].ToString();
            }
            else
            {
                result = inputText[inputText.Length / 2 - 1].ToString();
                result += inputText[inputText.Length / 2];
            }

            Console.WriteLine(result);
        }
    }
}
