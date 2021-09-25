using System;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            // The System.IO.Stream Class

            // Methods of System.IO.Stream Class:
            //int Read(byte[] buffer, int offset, int count);

            //Write(byte[] buffer, int offset, int count);

            // The FileStream Class
            //var fs = new FileStream(string fileName, FileMode, [FileAccess], [FileShare]);

            // .NET API for Easily Working with Files - File Class in .NET

            //File.ReadAllText() -> string - reads a text file at once
            // using System.IO;
            // ...
            // string text = File.ReadAllText("file.txt"):

            // File.ReadAllLines() -> string[] - reads a text file's lines
            // using System.IO;
            // ...
            // string[] lines = File.ReadAllLines("file.txt");

        }
    }
}
