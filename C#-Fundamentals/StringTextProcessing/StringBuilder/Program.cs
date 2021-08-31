using System;
using System.Text;

namespace StringBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder("pesho");
            // text += "word"
            text.Append("word");

            // text += "some string \n"

            text.AppendLine("new words");

            Console.WriteLine(text);
            string textAsString = text.ToString();
            StringBuilder textAsBuilder = new StringBuilder(textAsString);
        }
    }
}
