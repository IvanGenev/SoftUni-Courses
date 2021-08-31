using System;
using System.IO;

namespace TryFinallyException
{
    class DisposePattern
    {
        static void Readfile(string fileName)
        {
            TextReader reader = new StreamReader(fileName);
            try
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
            finally
            {
                // Always close "reader" (first check if properly pened)
                    reader.Close();
            }
        }

        static void Main()
        {

        }
    }
}
