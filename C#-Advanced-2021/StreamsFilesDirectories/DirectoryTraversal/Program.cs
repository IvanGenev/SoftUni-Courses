using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            // "." - returns all files
            // "*.txt" - returns all .txt files

            string[] allFiles = Directory.GetFiles(".");

            Dictionary<string, Dictionary<string, double>> groupedFiles = new Dictionary<string, Dictionary<string, double>>();

            Console.WriteLine(string.Join(Environment.NewLine, allFiles)); // Prints all files in the current directory

            foreach (var file in allFiles)
            {
                FileInfo fileInfo = new FileInfo(file);

                if (!groupedFiles.ContainsKey(fileInfo.Extension))
                {
                    groupedFiles.Add(fileInfo.Extension, new Dictionary<string, double>());
                }

                double size = (double)fileInfo.Length / 1024;

                groupedFiles[fileInfo.Extension].Add(fileInfo.Name, size);

                ////Console.WriteLine(fileInfo.FullName);
                //Console.WriteLine(fileInfo.Name);
                //Console.WriteLine(fileInfo.Extension);
                //Console.WriteLine((double)fileInfo.Length / 1024); // calculates the size in kilobytes
            }

            var sortedFiles = groupedFiles
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key);

            List<string> lines = new List<string>();

            foreach (var file in sortedFiles)
            {
                lines.Add(file.Key);

                foreach (var item in file.Value)
                {
                    lines.Add($"--{item.Key} - {item.Value:F3}kb\n");
                }
            }

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt";

            File.WriteAllLines(path, lines); // 2:08
        }
    }
}
