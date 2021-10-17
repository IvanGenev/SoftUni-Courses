using System;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceDirectory = @"C:\Users\Client\Desktop\newFolder";
            string targetDirectory = @"C:\Users\Client\Desktop\result.zip";
            string destinationDirectory = @"C:\Users\Client\Desktop\newresult";

            ZipFile.CreateFromDirectory(sourceDirectory, targetDirectory);
            ZipFile.ExtractToDirectory(targetDirectory, destinationDirectory);
        }
    }
}
