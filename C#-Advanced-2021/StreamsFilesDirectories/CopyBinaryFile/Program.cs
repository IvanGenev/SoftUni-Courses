using System;
using System.IO;

namespace CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Short way:
            File.Copy("copyMe.png", "copyMecopy1.png");

            // Long way:
            FileStream fileReader = new FileStream("copyMe.png", FileMode.Open);
            FileStream fileWriter = new FileStream("copyMecopy.png", FileMode.Create);

            byte[] arrayOfBytes = new byte[256];

            while (true)
            {
                int currentBytes = fileReader.Read(arrayOfBytes, 0, arrayOfBytes.Length);

                if (currentBytes == 0)
                {
                    fileWriter.Flush(); // Very important to do, otherwise last part of image will be missing
                    break;
                }

                fileWriter.Write(arrayOfBytes, 0, arrayOfBytes.Length);
            }

            Console.WriteLine("Done");
        }
    }
}
