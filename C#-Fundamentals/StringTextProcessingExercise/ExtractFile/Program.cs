using System;
using System.IO;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullPath = Console.ReadLine();

            //var name = Path.GetFileNameWithoutExtension(fullPath);
            //var extension = Path.GetExtension(fullPath).Replace(".", "");

            int lastIndex = fullPath.LastIndexOf('\\');

            string fileName = fullPath.Substring(lastIndex + 1);

            int extensionIndex = fileName.LastIndexOf('.');
            string extension = fileName.Substring(extensionIndex + 1);

            string name = fileName.Substring(0, extensionIndex);

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
