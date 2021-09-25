using System;
using System.IO;

namespace UsingStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Streams, readers, files, et. use certain resources
            // Using Statements closes them and releases their resources:

            using (StreamReader reader = new StreamReader("input.txt"))
            {

            }
        }
    }
}
