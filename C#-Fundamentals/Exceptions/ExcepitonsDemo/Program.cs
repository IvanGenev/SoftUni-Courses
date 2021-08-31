using System;
using System.IO;

namespace ExcepitonsDemo
{
    class ExcepitonsDemo
    {
        static void Main()
        {
            string fileName = "WrongTextFile.txt";
            ReadFile(fileName);
        }

        static void ReadFile(string filename)
        {
            // Exceptions could be throuwn in the code below
            try
            {
                TextReader reader = new StreamReader(filename);
                string line = reader.ReadLine();
                Console.WriteLine(line);
                reader.Close();
            }
            catch (FileNotFoundException fnfe)
            {
                // Exception handler for FileNotFoundException
                // We just inform the user that there is no such file
                Console.WriteLine("The file '{0}' is not found.", filename);
            }
            catch (IOException ioe)
            {
                // Exceptoin handler for the other input/output exceptions
                // We just print the stack trace on the console
                Console.WriteLine(ioe.StackTrace);
            }
        }
    }
}
